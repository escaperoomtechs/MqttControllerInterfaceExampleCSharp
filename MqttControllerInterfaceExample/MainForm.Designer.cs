
namespace MqttControllerInterfaceExample
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.relay1 = new System.Windows.Forms.CheckBox();
            this.relay0 = new System.Windows.Forms.CheckBox();
            this.output5 = new System.Windows.Forms.CheckBox();
            this.output4 = new System.Windows.Forms.CheckBox();
            this.output3 = new System.Windows.Forms.CheckBox();
            this.output2 = new System.Windows.Forms.CheckBox();
            this.output1 = new System.Windows.Forms.CheckBox();
            this.output0 = new System.Windows.Forms.CheckBox();
            this.input7 = new System.Windows.Forms.CheckBox();
            this.input6 = new System.Windows.Forms.CheckBox();
            this.input5 = new System.Windows.Forms.CheckBox();
            this.input4 = new System.Windows.Forms.CheckBox();
            this.input3 = new System.Windows.Forms.CheckBox();
            this.input2 = new System.Windows.Forms.CheckBox();
            this.input1 = new System.Windows.Forms.CheckBox();
            this.input0 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.activityList = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtControllerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1108, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(88, 17);
            this.connectionStatusLabel.Text = "Not Connected";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.relay1);
            this.groupBox1.Controls.Add(this.relay0);
            this.groupBox1.Controls.Add(this.output5);
            this.groupBox1.Controls.Add(this.output4);
            this.groupBox1.Controls.Add(this.output3);
            this.groupBox1.Controls.Add(this.output2);
            this.groupBox1.Controls.Add(this.output1);
            this.groupBox1.Controls.Add(this.output0);
            this.groupBox1.Controls.Add(this.input7);
            this.groupBox1.Controls.Add(this.input6);
            this.groupBox1.Controls.Add(this.input5);
            this.groupBox1.Controls.Add(this.input4);
            this.groupBox1.Controls.Add(this.input3);
            this.groupBox1.Controls.Add(this.input2);
            this.groupBox1.Controls.Add(this.input1);
            this.groupBox1.Controls.Add(this.input0);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(832, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 587);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controller";
            // 
            // relay1
            // 
            this.relay1.AutoSize = true;
            this.relay1.Location = new System.Drawing.Point(152, 231);
            this.relay1.Name = "relay1";
            this.relay1.Size = new System.Drawing.Size(73, 20);
            this.relay1.TabIndex = 31;
            this.relay1.Text = "Relay 1";
            this.relay1.UseVisualStyleBackColor = true;
            this.relay1.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // relay0
            // 
            this.relay0.AutoSize = true;
            this.relay0.Location = new System.Drawing.Point(152, 205);
            this.relay0.Name = "relay0";
            this.relay0.Size = new System.Drawing.Size(73, 20);
            this.relay0.TabIndex = 30;
            this.relay0.Text = "Relay 0";
            this.relay0.UseVisualStyleBackColor = true;
            this.relay0.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // output5
            // 
            this.output5.AutoSize = true;
            this.output5.Location = new System.Drawing.Point(152, 163);
            this.output5.Name = "output5";
            this.output5.Size = new System.Drawing.Size(75, 20);
            this.output5.TabIndex = 29;
            this.output5.Text = "Output 5";
            this.output5.UseVisualStyleBackColor = true;
            this.output5.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // output4
            // 
            this.output4.AutoSize = true;
            this.output4.Location = new System.Drawing.Point(152, 137);
            this.output4.Name = "output4";
            this.output4.Size = new System.Drawing.Size(75, 20);
            this.output4.TabIndex = 28;
            this.output4.Text = "Output 4";
            this.output4.UseVisualStyleBackColor = true;
            this.output4.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // output3
            // 
            this.output3.AutoSize = true;
            this.output3.Location = new System.Drawing.Point(152, 111);
            this.output3.Name = "output3";
            this.output3.Size = new System.Drawing.Size(75, 20);
            this.output3.TabIndex = 27;
            this.output3.Text = "Output 3";
            this.output3.UseVisualStyleBackColor = true;
            this.output3.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // output2
            // 
            this.output2.AutoSize = true;
            this.output2.Location = new System.Drawing.Point(152, 85);
            this.output2.Name = "output2";
            this.output2.Size = new System.Drawing.Size(75, 20);
            this.output2.TabIndex = 26;
            this.output2.Text = "Output 2";
            this.output2.UseVisualStyleBackColor = true;
            this.output2.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // output1
            // 
            this.output1.AutoSize = true;
            this.output1.Location = new System.Drawing.Point(152, 59);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(75, 20);
            this.output1.TabIndex = 25;
            this.output1.Text = "Output 1";
            this.output1.UseVisualStyleBackColor = true;
            this.output1.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // output0
            // 
            this.output0.AutoSize = true;
            this.output0.Location = new System.Drawing.Point(152, 33);
            this.output0.Name = "output0";
            this.output0.Size = new System.Drawing.Size(75, 20);
            this.output0.TabIndex = 24;
            this.output0.Text = "Output 0";
            this.output0.UseVisualStyleBackColor = true;
            this.output0.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // input7
            // 
            this.input7.AutoSize = true;
            this.input7.Location = new System.Drawing.Point(32, 215);
            this.input7.Name = "input7";
            this.input7.Size = new System.Drawing.Size(65, 20);
            this.input7.TabIndex = 23;
            this.input7.Text = "Input 7";
            this.input7.UseVisualStyleBackColor = true;
            // 
            // input6
            // 
            this.input6.AutoSize = true;
            this.input6.Location = new System.Drawing.Point(32, 189);
            this.input6.Name = "input6";
            this.input6.Size = new System.Drawing.Size(65, 20);
            this.input6.TabIndex = 22;
            this.input6.Text = "Input 6";
            this.input6.UseVisualStyleBackColor = true;
            // 
            // input5
            // 
            this.input5.AutoSize = true;
            this.input5.Location = new System.Drawing.Point(32, 163);
            this.input5.Name = "input5";
            this.input5.Size = new System.Drawing.Size(65, 20);
            this.input5.TabIndex = 21;
            this.input5.Text = "Input 5";
            this.input5.UseVisualStyleBackColor = true;
            // 
            // input4
            // 
            this.input4.AutoSize = true;
            this.input4.Location = new System.Drawing.Point(32, 137);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(65, 20);
            this.input4.TabIndex = 20;
            this.input4.Text = "Input 4";
            this.input4.UseVisualStyleBackColor = true;
            // 
            // input3
            // 
            this.input3.AutoSize = true;
            this.input3.Location = new System.Drawing.Point(32, 111);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(65, 20);
            this.input3.TabIndex = 19;
            this.input3.Text = "Input 3";
            this.input3.UseVisualStyleBackColor = true;
            // 
            // input2
            // 
            this.input2.AutoSize = true;
            this.input2.Location = new System.Drawing.Point(32, 85);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(65, 20);
            this.input2.TabIndex = 18;
            this.input2.Text = "Input 2";
            this.input2.UseVisualStyleBackColor = true;
            // 
            // input1
            // 
            this.input1.AutoSize = true;
            this.input1.Location = new System.Drawing.Point(32, 59);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(65, 20);
            this.input1.TabIndex = 17;
            this.input1.Text = "Input 1";
            this.input1.UseVisualStyleBackColor = true;
            // 
            // input0
            // 
            this.input0.AutoSize = true;
            this.input0.Location = new System.Drawing.Point(32, 33);
            this.input0.Name = "input0";
            this.input0.Size = new System.Drawing.Size(65, 20);
            this.input0.TabIndex = 16;
            this.input0.Text = "Input 0";
            this.input0.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDisconnect);
            this.groupBox2.Controls.Add(this.activityList);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtControllerName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtServerIp);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(832, 587);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // activityList
            // 
            this.activityList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activityList.FormattingEnabled = true;
            this.activityList.ItemHeight = 16;
            this.activityList.Location = new System.Drawing.Point(16, 137);
            this.activityList.Name = "activityList";
            this.activityList.Size = new System.Drawing.Size(803, 436);
            this.activityList.TabIndex = 6;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(672, 97);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(147, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "(case sensitive)";
            // 
            // txtControllerName
            // 
            this.txtControllerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtControllerName.Location = new System.Drawing.Point(140, 59);
            this.txtControllerName.Name = "txtControllerName";
            this.txtControllerName.Size = new System.Drawing.Size(679, 22);
            this.txtControllerName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Controller Name:";
            // 
            // txtServerIp
            // 
            this.txtServerIp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerIp.Location = new System.Drawing.Point(140, 22);
            this.txtServerIp.Name = "txtServerIp";
            this.txtServerIp.Size = new System.Drawing.Size(679, 22);
            this.txtServerIp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MQTT Server IP:";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(521, 97);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(128, 23);
            this.btnDisconnect.TabIndex = 7;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 609);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "Escape Room Techs MQTT Example";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connectionStatusLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox relay1;
        private System.Windows.Forms.CheckBox relay0;
        private System.Windows.Forms.CheckBox output5;
        private System.Windows.Forms.CheckBox output4;
        private System.Windows.Forms.CheckBox output3;
        private System.Windows.Forms.CheckBox output2;
        private System.Windows.Forms.CheckBox output1;
        private System.Windows.Forms.CheckBox output0;
        private System.Windows.Forms.CheckBox input7;
        private System.Windows.Forms.CheckBox input6;
        private System.Windows.Forms.CheckBox input5;
        private System.Windows.Forms.CheckBox input4;
        private System.Windows.Forms.CheckBox input3;
        private System.Windows.Forms.CheckBox input2;
        private System.Windows.Forms.CheckBox input1;
        private System.Windows.Forms.CheckBox input0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox activityList;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtControllerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

