namespace Lab4_Bai5
{
    partial class Lab4_Bai5
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_Name = new TextBox();
            richTextBox_response = new RichTextBox();
            textBox_Pass = new TextBox();
            textBox_URL = new TextBox();
            button_login = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox_Name
            // 
            textBox_Name.BorderStyle = BorderStyle.FixedSingle;
            textBox_Name.Location = new Point(98, 44);
            textBox_Name.Margin = new Padding(3, 2, 3, 2);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(240, 23);
            textBox_Name.TabIndex = 0;
            // 
            // richTextBox_response
            // 
            richTextBox_response.BorderStyle = BorderStyle.FixedSingle;
            richTextBox_response.Location = new Point(27, 116);
            richTextBox_response.Margin = new Padding(3, 2, 3, 2);
            richTextBox_response.Name = "richTextBox_response";
            richTextBox_response.Size = new Size(406, 137);
            richTextBox_response.TabIndex = 1;
            richTextBox_response.Text = "";
            // 
            // textBox_Pass
            // 
            textBox_Pass.BorderStyle = BorderStyle.FixedSingle;
            textBox_Pass.Location = new Point(98, 76);
            textBox_Pass.Margin = new Padding(3, 2, 3, 2);
            textBox_Pass.Name = "textBox_Pass";
            textBox_Pass.PasswordChar = '*';
            textBox_Pass.Size = new Size(240, 23);
            textBox_Pass.TabIndex = 2;
            // 
            // textBox_URL
            // 
            textBox_URL.BorderStyle = BorderStyle.FixedSingle;
            textBox_URL.Location = new Point(98, 11);
            textBox_URL.Margin = new Padding(3, 2, 3, 2);
            textBox_URL.Name = "textBox_URL";
            textBox_URL.Size = new Size(334, 23);
            textBox_URL.TabIndex = 3;
            textBox_URL.Text = "https://nt106.uitiot.vn/auth/token";
            // 
            // button_login
            // 
            button_login.Location = new Point(349, 44);
            button_login.Margin = new Padding(3, 2, 3, 2);
            button_login.Name = "button_login";
            button_login.Size = new Size(82, 54);
            button_login.TabIndex = 4;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 13);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 5;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 49);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 81);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // Lab4_Bai5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 272);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_login);
            Controls.Add(textBox_URL);
            Controls.Add(textBox_Pass);
            Controls.Add(richTextBox_response);
            Controls.Add(textBox_Name);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Lab4_Bai5";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Name;
        private RichTextBox richTextBox_response;
        private TextBox textBox_Pass;
        private TextBox textBox_URL;
        private Button button_login;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
