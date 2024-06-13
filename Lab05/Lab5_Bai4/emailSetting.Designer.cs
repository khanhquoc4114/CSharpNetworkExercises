namespace Lab5_Bai4
{
    partial class emailSetting
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
            groupBox1 = new GroupBox();
            smtp_port = new TextBox();
            imap_port = new TextBox();
            smtp_requiressl = new CheckBox();
            iamp_requiressl = new CheckBox();
            smtpserver = new TextBox();
            imapserver = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBox_password = new TextBox();
            textBox_username = new TextBox();
            textBox_nickname = new TextBox();
            button_test = new Button();
            button_save = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(244, 50);
            label1.TabIndex = 0;
            label1.Text = "Email Config";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(smtp_port);
            groupBox1.Controls.Add(imap_port);
            groupBox1.Controls.Add(smtp_requiressl);
            groupBox1.Controls.Add(iamp_requiressl);
            groupBox1.Controls.Add(smtpserver);
            groupBox1.Controls.Add(imapserver);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(34, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(497, 138);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Email server configuration";
            // 
            // smtp_port
            // 
            smtp_port.Location = new Point(351, 58);
            smtp_port.Name = "smtp_port";
            smtp_port.Size = new Size(125, 27);
            smtp_port.TabIndex = 9;
            smtp_port.Text = "465";
            // 
            // imap_port
            // 
            imap_port.Location = new Point(98, 58);
            imap_port.Name = "imap_port";
            imap_port.Size = new Size(125, 27);
            imap_port.TabIndex = 8;
            imap_port.Text = "993";
            // 
            // smtp_requiressl
            // 
            smtp_requiressl.AutoSize = true;
            smtp_requiressl.Checked = true;
            smtp_requiressl.CheckState = CheckState.Checked;
            smtp_requiressl.Location = new Point(351, 91);
            smtp_requiressl.Name = "smtp_requiressl";
            smtp_requiressl.Size = new Size(109, 24);
            smtp_requiressl.TabIndex = 7;
            smtp_requiressl.Text = "Require SSL";
            smtp_requiressl.UseVisualStyleBackColor = true;
            // 
            // iamp_requiressl
            // 
            iamp_requiressl.AutoSize = true;
            iamp_requiressl.Checked = true;
            iamp_requiressl.CheckState = CheckState.Checked;
            iamp_requiressl.Location = new Point(98, 91);
            iamp_requiressl.Name = "iamp_requiressl";
            iamp_requiressl.Size = new Size(109, 24);
            iamp_requiressl.TabIndex = 6;
            iamp_requiressl.Text = "Require SSL";
            iamp_requiressl.UseVisualStyleBackColor = true;
            // 
            // smtpserver
            // 
            smtpserver.Location = new Point(351, 25);
            smtpserver.Name = "smtpserver";
            smtpserver.Size = new Size(125, 27);
            smtpserver.TabIndex = 5;
            smtpserver.Text = "smtp.gmail.com";
            // 
            // imapserver
            // 
            imapserver.Location = new Point(98, 25);
            imapserver.Name = "imapserver";
            imapserver.Size = new Size(125, 27);
            imapserver.TabIndex = 4;
            imapserver.Text = "imap.gmail.com";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 65);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 3;
            label5.Text = "SMTP Port";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 32);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 2;
            label4.Text = "SMTP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 65);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 1;
            label3.Text = "IMAP Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 32);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 0;
            label2.Text = "IMAP";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox_password);
            groupBox2.Controls.Add(textBox_username);
            groupBox2.Controls.Add(textBox_nickname);
            groupBox2.Location = new Point(34, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(352, 136);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Account";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 99);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 11;
            label8.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 66);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 10;
            label7.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 33);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 9;
            label6.Text = "Nickname";
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(98, 92);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(242, 27);
            textBox_password.TabIndex = 8;
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(98, 59);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(242, 27);
            textBox_username.TabIndex = 7;
            // 
            // textBox_nickname
            // 
            textBox_nickname.Location = new Point(98, 26);
            textBox_nickname.Name = "textBox_nickname";
            textBox_nickname.ReadOnly = true;
            textBox_nickname.Size = new Size(242, 27);
            textBox_nickname.TabIndex = 6;
            // 
            // button_test
            // 
            button_test.Location = new Point(392, 277);
            button_test.Name = "button_test";
            button_test.Size = new Size(139, 29);
            button_test.TabIndex = 3;
            button_test.Text = "Test connection";
            button_test.UseVisualStyleBackColor = true;
            button_test.Click += button_test_Click;
            // 
            // button_save
            // 
            button_save.Location = new Point(392, 317);
            button_save.Name = "button_save";
            button_save.Size = new Size(139, 55);
            button_save.TabIndex = 4;
            button_save.Text = "Save Exit";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // emailSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 403);
            Controls.Add(button_save);
            Controls.Add(button_test);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "emailSetting";
            Text = "emailSetting";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox smtp_requiressl;
        private CheckBox iamp_requiressl;
        private TextBox smtpserver;
        private TextBox imapserver;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBox_password;
        private TextBox textBox_username;
        private TextBox textBox_nickname;
        private TextBox smtp_port;
        private TextBox imap_port;
        private Button button_test;
        private Button button_save;
    }
}