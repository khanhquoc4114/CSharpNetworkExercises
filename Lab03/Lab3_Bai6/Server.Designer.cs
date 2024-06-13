namespace Lab3_Bai6
{
    partial class Server
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
            this.txtUserNumber = new System.Windows.Forms.TextBox();
            this.lblUserNumber = new System.Windows.Forms.Label();
            this.btnListen = new System.Windows.Forms.Button();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnSendFlie = new System.Windows.Forms.Button();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.rtbChatBox = new System.Windows.Forms.RichTextBox();
            this.flpFile = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEmoji = new System.Windows.Forms.Button();
            this.txtEmoji = new System.Windows.Forms.TextBox();
            this.flpEmoji = new System.Windows.Forms.FlowLayoutPanel();
            this.gbInfo.SuspendLayout();
            this.gbMessage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flpEmoji.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserNumber
            // 
            this.txtUserNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserNumber.Location = new System.Drawing.Point(118, 41);
            this.txtUserNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserNumber.Name = "txtUserNumber";
            this.txtUserNumber.Size = new System.Drawing.Size(76, 20);
            this.txtUserNumber.TabIndex = 11;
            this.txtUserNumber.Text = "2";
            // 
            // lblUserNumber
            // 
            this.lblUserNumber.AutoSize = true;
            this.lblUserNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNumber.Location = new System.Drawing.Point(4, 43);
            this.lblUserNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserNumber.Name = "lblUserNumber";
            this.lblUserNumber.Size = new System.Drawing.Size(92, 17);
            this.lblUserNumber.TabIndex = 10;
            this.lblUserNumber.Text = "Default users";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(127, 84);
            this.btnListen.Margin = new System.Windows.Forms.Padding(2);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 24);
            this.btnListen.TabIndex = 9;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // txtServerPort
            // 
            this.txtServerPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerPort.Location = new System.Drawing.Point(118, 17);
            this.txtServerPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(76, 20);
            this.txtServerPort.TabIndex = 7;
            this.txtServerPort.Text = "8888";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(4, 19);
            this.lblPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(80, 17);
            this.lblPort.TabIndex = 6;
            this.lblPort.Text = "Server Port";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(604, 19);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(56, 26);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Location = new System.Drawing.Point(4, 17);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(532, 26);
            this.txtMessage.TabIndex = 15;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblPort);
            this.gbInfo.Controls.Add(this.lblUserNumber);
            this.gbInfo.Controls.Add(this.txtServerPort);
            this.gbInfo.Controls.Add(this.txtUserNumber);
            this.gbInfo.Location = new System.Drawing.Point(9, 10);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbInfo.Size = new System.Drawing.Size(197, 69);
            this.gbInfo.TabIndex = 16;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // btnSendFlie
            // 
            this.btnSendFlie.Location = new System.Drawing.Point(573, 19);
            this.btnSendFlie.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendFlie.Name = "btnSendFlie";
            this.btnSendFlie.Size = new System.Drawing.Size(27, 26);
            this.btnSendFlie.TabIndex = 17;
            this.btnSendFlie.Text = "I";
            this.btnSendFlie.UseVisualStyleBackColor = true;
            this.btnSendFlie.Click += new System.EventHandler(this.btnSendFlie_Click);
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.btnEmoji);
            this.gbMessage.Controls.Add(this.txtMessage);
            this.gbMessage.Controls.Add(this.btnSendFlie);
            this.gbMessage.Controls.Add(this.btnSend);
            this.gbMessage.Location = new System.Drawing.Point(9, 342);
            this.gbMessage.Margin = new System.Windows.Forms.Padding(2);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Padding = new System.Windows.Forms.Padding(2);
            this.gbMessage.Size = new System.Drawing.Size(664, 58);
            this.gbMessage.TabIndex = 18;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Message";
            // 
            // rtbChatBox
            // 
            this.rtbChatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbChatBox.Font = new System.Drawing.Font("Segoe UI Emoji", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbChatBox.Location = new System.Drawing.Point(222, 10);
            this.rtbChatBox.Name = "rtbChatBox";
            this.rtbChatBox.ReadOnly = true;
            this.rtbChatBox.Size = new System.Drawing.Size(451, 327);
            this.rtbChatBox.TabIndex = 19;
            this.rtbChatBox.Text = "";
            // 
            // flpFile
            // 
            this.flpFile.AutoScroll = true;
            this.flpFile.Location = new System.Drawing.Point(7, 19);
            this.flpFile.Name = "flpFile";
            this.flpFile.Size = new System.Drawing.Size(194, 189);
            this.flpFile.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpFile);
            this.groupBox1.Location = new System.Drawing.Point(9, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 214);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // btnEmoji
            // 
            this.btnEmoji.Location = new System.Drawing.Point(541, 19);
            this.btnEmoji.Name = "btnEmoji";
            this.btnEmoji.Size = new System.Drawing.Size(27, 26);
            this.btnEmoji.TabIndex = 18;
            this.btnEmoji.Text = "E";
            this.btnEmoji.UseVisualStyleBackColor = true;
            this.btnEmoji.Click += new System.EventHandler(this.btnEmoji_Click);
            // 
            // txtEmoji
            // 
            this.txtEmoji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmoji.Location = new System.Drawing.Point(3, 3);
            this.txtEmoji.Name = "txtEmoji";
            this.txtEmoji.Size = new System.Drawing.Size(481, 20);
            this.txtEmoji.TabIndex = 2;
            this.txtEmoji.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmoji_KeyDown);
            // 
            // flpEmoji
            // 
            this.flpEmoji.AutoScroll = true;
            this.flpEmoji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpEmoji.Controls.Add(this.txtEmoji);
            this.flpEmoji.Location = new System.Drawing.Point(149, 90);
            this.flpEmoji.Name = "flpEmoji";
            this.flpEmoji.Size = new System.Drawing.Size(525, 247);
            this.flpEmoji.TabIndex = 22;
            this.flpEmoji.Visible = false;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 409);
            this.Controls.Add(this.flpEmoji);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbChatBox);
            this.Controls.Add(this.gbMessage);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnListen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Server";
            this.Text = "TCP Server";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flpEmoji.ResumeLayout(false);
            this.flpEmoji.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserNumber;
        private System.Windows.Forms.Label lblUserNumber;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnSendFlie;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.RichTextBox rtbChatBox;
        private System.Windows.Forms.FlowLayoutPanel flpFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEmoji;
        private System.Windows.Forms.TextBox txtEmoji;
        private System.Windows.Forms.FlowLayoutPanel flpEmoji;
    }
}