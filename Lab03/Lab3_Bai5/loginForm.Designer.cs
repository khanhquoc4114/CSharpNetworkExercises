namespace Lab03_Bai5
{
    partial class loginForm
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
            textBox_id = new TextBox();
            label1 = new Label();
            button_login = new Button();
            textBox_ip = new TextBox();
            textBox_port = new TextBox();
            label_ip = new Label();
            label_port = new Label();
            SuspendLayout();
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(106, 31);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(170, 27);
            textBox_id.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 34);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 2;
            label1.Text = "IDNCC";
            // 
            // button_login
            // 
            button_login.Location = new Point(306, 52);
            button_login.Name = "button_login";
            button_login.Size = new Size(94, 76);
            button_login.TabIndex = 4;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // textBox_ip
            // 
            textBox_ip.Location = new Point(106, 77);
            textBox_ip.Name = "textBox_ip";
            textBox_ip.Size = new Size(170, 27);
            textBox_ip.TabIndex = 5;
            textBox_ip.Text = "127.0.0.1";
            // 
            // textBox_port
            // 
            textBox_port.Location = new Point(106, 120);
            textBox_port.Name = "textBox_port";
            textBox_port.Size = new Size(170, 27);
            textBox_port.TabIndex = 6;
            textBox_port.Text = "8080";
            // 
            // label_ip
            // 
            label_ip.AutoSize = true;
            label_ip.Location = new Point(31, 80);
            label_ip.Name = "label_ip";
            label_ip.Size = new Size(21, 20);
            label_ip.TabIndex = 8;
            label_ip.Text = "IP";
            // 
            // label_port
            // 
            label_port.AutoSize = true;
            label_port.Location = new Point(31, 120);
            label_port.Name = "label_port";
            label_port.Size = new Size(35, 20);
            label_port.TabIndex = 9;
            label_port.Text = "Port";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 195);
            Controls.Add(label_port);
            Controls.Add(label_ip);
            Controls.Add(textBox_port);
            Controls.Add(textBox_ip);
            Controls.Add(button_login);
            Controls.Add(label1);
            Controls.Add(textBox_id);
            Name = "loginForm";
            Text = "loginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_id;
        private Label label1;
        private Button button_login;
        private TextBox textBox_ip;
        private TextBox textBox_port;
        private Label label_ip;
        private Label label_port;
    }
}