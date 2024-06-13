namespace Lab4_Bai6
{
    partial class Lab4_Bai6
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button_login = new Button();
            textBox_URL = new TextBox();
            textBox_Pass = new TextBox();
            richTextBox_response = new RichTextBox();
            textBox_Name = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 71);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 39);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 14;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 3);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 13;
            label1.Text = "URL";
            // 
            // button_login
            // 
            button_login.Location = new Point(348, 34);
            button_login.Margin = new Padding(3, 2, 3, 2);
            button_login.Name = "button_login";
            button_login.Size = new Size(82, 54);
            button_login.TabIndex = 12;
            button_login.Text = "Get";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_Post_Click;
            // 
            // textBox_URL
            // 
            textBox_URL.BorderStyle = BorderStyle.FixedSingle;
            textBox_URL.Location = new Point(97, 1);
            textBox_URL.Margin = new Padding(3, 2, 3, 2);
            textBox_URL.Name = "textBox_URL";
            textBox_URL.Size = new Size(334, 23);
            textBox_URL.TabIndex = 11;
            textBox_URL.Text = "https://nt106.uitiot.vn/api/v1/user/me";
            // 
            // textBox_Pass
            // 
            textBox_Pass.BorderStyle = BorderStyle.FixedSingle;
            textBox_Pass.Location = new Point(97, 66);
            textBox_Pass.Margin = new Padding(3, 2, 3, 2);
            textBox_Pass.Name = "textBox_Pass";
            textBox_Pass.PasswordChar = '*';
            textBox_Pass.Size = new Size(240, 23);
            textBox_Pass.TabIndex = 10;
            // 
            // richTextBox_response
            // 
            richTextBox_response.BorderStyle = BorderStyle.FixedSingle;
            richTextBox_response.Location = new Point(25, 106);
            richTextBox_response.Margin = new Padding(3, 2, 3, 2);
            richTextBox_response.Name = "richTextBox_response";
            richTextBox_response.Size = new Size(406, 137);
            richTextBox_response.TabIndex = 9;
            richTextBox_response.Text = "";
            // 
            // textBox_Name
            // 
            textBox_Name.BorderStyle = BorderStyle.FixedSingle;
            textBox_Name.Location = new Point(97, 34);
            textBox_Name.Margin = new Padding(3, 2, 3, 2);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(240, 23);
            textBox_Name.TabIndex = 8;
            // 
            // Lab4_Bai6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 267);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_login);
            Controls.Add(textBox_URL);
            Controls.Add(textBox_Pass);
            Controls.Add(richTextBox_response);
            Controls.Add(textBox_Name);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Lab4_Bai6";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button button_login;
        private TextBox textBox_URL;
        private TextBox textBox_Pass;
        private RichTextBox richTextBox_response;
        private TextBox textBox_Name;
    }
}
