namespace Lab4_Bai7
{
    partial class SignUp
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
            groupBox1 = new GroupBox();
            textBox_pass = new TextBox();
            label3 = new Label();
            textBox_name = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btn_Female = new RadioButton();
            btn_Male = new RadioButton();
            label11 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox_phone = new TextBox();
            label6 = new Label();
            textBox_lName = new TextBox();
            label7 = new Label();
            textBox_fName = new TextBox();
            label4 = new Label();
            textBox_email = new TextBox();
            label5 = new Label();
            label1 = new Label();
            button_submit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_pass);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox_name);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(28, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 111);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign Up";
            // 
            // textBox_pass
            // 
            textBox_pass.Location = new Point(89, 62);
            textBox_pass.Name = "textBox_pass";
            textBox_pass.Size = new Size(251, 27);
            textBox_pass.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 69);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(89, 20);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(251, 27);
            textBox_name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 27);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(btn_Female);
            groupBox2.Controls.Add(btn_Male);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox_phone);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox_lName);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox_fName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox_email);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(28, 223);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 317);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "User  Information";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Việt Nam", "English", "C#", "C++", "Python" });
            comboBox1.Location = new Point(89, 236);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 28);
            comboBox1.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(89, 195);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(251, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // btn_Female
            // 
            btn_Female.AutoSize = true;
            btn_Female.Location = new Point(208, 276);
            btn_Female.Name = "btn_Female";
            btn_Female.Size = new Size(78, 24);
            btn_Female.TabIndex = 18;
            btn_Female.TabStop = true;
            btn_Female.Text = "Female";
            btn_Female.UseVisualStyleBackColor = true;
            // 
            // btn_Male
            // 
            btn_Male.AutoSize = true;
            btn_Male.Location = new Point(89, 276);
            btn_Male.Name = "btn_Male";
            btn_Male.Size = new Size(63, 24);
            btn_Male.TabIndex = 17;
            btn_Male.TabStop = true;
            btn_Male.Text = "Male";
            btn_Male.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 280);
            label11.Name = "label11";
            label11.Size = new Size(32, 20);
            label11.TabIndex = 16;
            label11.Text = "Sex";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 244);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 14;
            label8.Text = "Language";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 202);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 12;
            label9.Text = "Birthday";
            // 
            // textBox_phone
            // 
            textBox_phone.Location = new Point(89, 152);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(251, 27);
            textBox_phone.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 159);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 10;
            label6.Text = "Phone";
            // 
            // textBox_lName
            // 
            textBox_lName.Location = new Point(89, 110);
            textBox_lName.Name = "textBox_lName";
            textBox_lName.Size = new Size(251, 27);
            textBox_lName.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 117);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 8;
            label7.Text = "Lastname";
            // 
            // textBox_fName
            // 
            textBox_fName.Location = new Point(89, 68);
            textBox_fName.Name = "textBox_fName";
            textBox_fName.Size = new Size(251, 27);
            textBox_fName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 75);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 6;
            label4.Text = "Firstname";
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(89, 26);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(251, 27);
            textBox_email.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 33);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Email";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(62, 42);
            label1.Name = "label1";
            label1.Size = new Size(287, 46);
            label1.TabIndex = 2;
            label1.Text = "HÔM NAY ĂN GÌ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_submit
            // 
            button_submit.Location = new Point(294, 546);
            button_submit.Name = "button_submit";
            button_submit.Size = new Size(94, 29);
            button_submit.TabIndex = 3;
            button_submit.Text = "Submit";
            button_submit.UseVisualStyleBackColor = true;
            button_submit.Click += button_submit_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 584);
            Controls.Add(button_submit);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SignUp";
            Text = "Hôm nay ăn gì - Sign up";
            FormClosed += SignUp_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox textBox_name;
        private Label label2;
        private TextBox textBox_pass;
        private Label label3;
        private TextBox textBox_phone;
        private Label label6;
        private TextBox textBox_lName;
        private Label label7;
        private TextBox textBox_fName;
        private Label label4;
        private TextBox textBox_email;
        private Label label5;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private RadioButton btn_Female;
        private RadioButton btn_Male;
        private Label label11;
        private ComboBox comboBox1;
        private Button button_submit;
    }
}
