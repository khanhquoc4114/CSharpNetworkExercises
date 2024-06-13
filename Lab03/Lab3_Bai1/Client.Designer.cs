namespace Lab3_Bai1
{
    partial class Client
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
            label1 = new Label();
            label2 = new Label();
            textBox_port = new TextBox();
            textBox_ip = new TextBox();
            richTextBox_message = new RichTextBox();
            button_send = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 20);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "IP remote host";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 20);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "Port";
            // 
            // textBox_port
            // 
            textBox_port.Location = new Point(278, 52);
            textBox_port.Name = "textBox_port";
            textBox_port.Size = new Size(122, 27);
            textBox_port.TabIndex = 3;
            textBox_port.Text = "8080";
            // 
            // textBox_ip
            // 
            textBox_ip.Location = new Point(43, 52);
            textBox_ip.Name = "textBox_ip";
            textBox_ip.Size = new Size(178, 27);
            textBox_ip.TabIndex = 4;
            // 
            // richTextBox_message
            // 
            richTextBox_message.Location = new Point(43, 98);
            richTextBox_message.Name = "richTextBox_message";
            richTextBox_message.Size = new Size(357, 182);
            richTextBox_message.TabIndex = 5;
            richTextBox_message.Text = "";
            // 
            // button_send
            // 
            button_send.Location = new Point(459, 151);
            button_send.Name = "button_send";
            button_send.Size = new Size(103, 60);
            button_send.TabIndex = 6;
            button_send.Text = "Send";
            button_send.UseVisualStyleBackColor = true;
            button_send.Click += button_send_Click;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 301);
            Controls.Add(button_send);
            Controls.Add(richTextBox_message);
            Controls.Add(textBox_ip);
            Controls.Add(textBox_port);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Client";
            Text = "Form1";
            FormClosing += Client_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_port;
        private TextBox textBox_ip;
        private RichTextBox richTextBox_message;
        private Button button_send;
    }
}