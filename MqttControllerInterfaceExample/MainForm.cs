using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MQTTnet;
using MQTTnet.Client;

namespace MqttControllerInterfaceExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region MQTT Connectivity

        MqttFactory mqttFactory;
        IMqttClient mqttClient;

        private Task OnMessageReceived(MqttApplicationMessageReceivedEventArgs args)
        {
            onTopicChanged(args.ApplicationMessage.Topic, args.ApplicationMessage.ConvertPayloadToString());

            return Task.CompletedTask;
        }

        private async void MqttConnect(String server)
        {
            try
            {
                // Create our factory and client, if needed.
                if (mqttFactory == null)
                {
                    mqttFactory = new MqttFactory();
                }
                if (mqttClient == null)
                {
                    mqttClient = mqttFactory.CreateMqttClient();

                    // Setup message handling before connecting.  We only need to connect the handler once,
                    // even if we reconnect using the same client again later.
                    mqttClient.ApplicationMessageReceivedAsync += OnMessageReceived;

                    // Add a handler if we're disconnected from the server, so we know to update the UI.
                    mqttClient.DisconnectedAsync += MqttClient_DisconnectedAsync;
                }

                // Build the options for connecting to the server using the server name provided as a parameter.
                var mqttClientOptions = new MqttClientOptionsBuilder().WithTcpServer(server).Build();

                // This will throw an exception if the server is not available.
                // The result from this message returns additional data which was sent 
                // from the server. Please refer to the MQTT protocol specification for details.
                var response = await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);

                // Call our own function to let the app know we're connected now.
                onConnectionStatusChanged(true);

                // Subscribe to the topic(s) we care about.
                string TopicFilter = "#";       // # means all topics
                var subscribeOptions = new MqttClientSubscribeOptionsBuilder().WithTopicFilter(TopicFilter).Build();

                await mqttClient.SubscribeAsync(subscribeOptions);
            }
            catch (Exception ex)
            {
                // If something goes wrong, show a message box and update the connected/disconnected data.
                MessageBox.Show(ex.ToString());

                onConnectionStatusChanged(mqttFactory != null && mqttClient != null && mqttClient.IsConnected);
            }
        }

        private Task MqttClient_DisconnectedAsync(MqttClientDisconnectedEventArgs arg)
        {
            // For now, we just note that the disconnect has occurred.
            // In a game environment, you'd want to attempt reconnection
            // with a backoff time so the game automatically recovers
            // if there's a brief network outage.
            onConnectionStatusChanged(false);
            return Task.CompletedTask;
        }

        private async void MqttDisconnect()
        {
            if (mqttFactory != null && mqttClient != null && mqttClient.IsConnected)
            {
                // Send a clean disconnect to the server by calling _DisconnectAsync_. Without this the TCP connection
                // gets dropped and the server will handle this as a non clean disconnect (see MQTT spec for details).
                var mqttClientDisconnectOptions = mqttFactory.CreateClientDisconnectOptionsBuilder().Build();

                await mqttClient.DisconnectAsync(mqttClientDisconnectOptions, CancellationToken.None);

                onConnectionStatusChanged(false);
            }
        }

        // Convenience method to send a message to the server, and silently
        // fail if it isn't connected.
        private async void SendMessage(string topic, string message)
        {
            if (mqttClient != null && mqttClient.IsConnected)
            {
                await mqttClient.PublishStringAsync(topic, message);
            }
        }

        #endregion

        // When we receive a message from the server, update the UI.
        private void onTopicChanged(string topic, string payload)
        {
            // We call BeginInvoke because we're about to change the UI, which can only
            // happen on the UI thread.  BeginInvoke pushes a chunk of code onto that thread
            // to run, where it's able to safely operate.
            this.BeginInvoke((Action)(() =>
            {
                // Add a log entry to the list of all received messages.
                activityList.Items.Insert(0, String.Format("{0}: {1}", topic, payload));

                // If we get a message for Controller/get/sometopic...
                var prefix = txtControllerName.Text + "/get/";

                if (topic.StartsWith(prefix))
                {
                    // Remove the prefix, interpret the payload as "On" or "Off" as a boolean, and call another function.
                    updateCheckboxFromController(topic.Replace(prefix, ""), payload == "On");

                    // You could do anything you like here for your game logic.
                }
            }));
        }

        // Handle a received checkbox click event by sending an outbound message to the controller to change the state.
        private void changeControllerState(string topic, bool newState)
        {
            SendMessage(txtControllerName.Text + "/set/" + topic, newState ? "On" : "Off");
        }

        // Handle an inbound message from the controller and update the UI accordingly.
        private void updateCheckboxFromController(string topic, bool newState)
        {
            this.BeginInvoke((Action)(() =>
            {
                // Try to find a checkbox with a matching name.
                var CheckboxMatchingTopic = this.Controls.Find(topic, true).FirstOrDefault();

                // If we find one...
                if (CheckboxMatchingTopic != null && CheckboxMatchingTopic is CheckBox)
                {
                    // update its Checked property.
                    (CheckboxMatchingTopic as CheckBox).Checked = newState;
                }
            }));
        }

        // Update the status bar and Connection button to indicate if we're connected or not.
        private void onConnectionStatusChanged(bool isConnected)
        {
            this.BeginInvoke((Action)(() =>
            {
                connectionStatusLabel.Text = isConnected ? "✅ Connected" : "❌ Not Connected";
                btnConnect.Enabled = !isConnected;
                btnDisconnect.Enabled = isConnected;
            }));
        }

        // Handle the click event on a checkbox.
        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            changeControllerState((sender as CheckBox).Name, (sender as CheckBox).Checked);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            onConnectionStatusChanged(false);
        }

        // Connect to the server when the Connect button is clicked.
        private void btnConnect_Click(object sender, EventArgs e)
        {
            MqttConnect(txtServerIp.Text);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            MqttDisconnect();
        }
    }
}
