namespace Lab4_Bai7
{
    partial class Login
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
            label3 = new Label();
            label2 = new Label();
            button_login = new Button();
            textBox_Pass = new TextBox();
            textBox_Name = new TextBox();
            label1 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 129);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 86);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 11;
            label2.Text = "Username";
            // 
            // button_login
            // 
            button_login.Location = new Point(336, 77);
            button_login.Name = "button_login";
            button_login.Size = new Size(94, 72);
            button_login.TabIndex = 10;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // textBox_Pass
            // 
            textBox_Pass.Location = new Point(117, 122);
            textBox_Pass.Name = "textBox_Pass";
            textBox_Pass.PasswordChar = '*';
            textBox_Pass.Size = new Size(195, 27);
            textBox_Pass.TabIndex = 9;
            textBox_Pass.KeyDown += textBox_Pass_KeyDown;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(117, 79);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(195, 27);
            textBox_Name.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 172);
            label1.Name = "label1";
            label1.Size = new Size(191, 20);
            label1.TabIndex = 13;
            label1.Text = "Don't have an account yet? ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(99, 21);
            label4.Name = "label4";
            label4.Size = new Size(238, 38);
            label4.TabIndex = 14;
            label4.Text = "HÔM NAY ĂN GÌ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(305, 172);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(59, 20);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 221);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button_login);
            Controls.Add(textBox_Pass);
            Controls.Add(textBox_Name);
            Name = "Login";
            Text = "Hôm nay ăn gì ?-  Login";
            FormClosed += Login_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Button button_login;
        private TextBox textBox_Pass;
        private TextBox textBox_Name;
        private Label label1;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}