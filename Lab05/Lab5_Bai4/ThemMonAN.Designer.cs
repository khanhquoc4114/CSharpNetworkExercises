namespace Lab4_Bai7
{
    partial class ThemMonAn
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
            textBox_Ten = new TextBox();
            richTextBox_Mota = new RichTextBox();
            label2 = new Label();
            button_them = new Button();
            textBox_Gia = new TextBox();
            textBox_HinhAnh = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button_clear = new Button();
            textBox_Diachi = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(76, 50);
            label1.Name = "label1";
            label1.Size = new Size(272, 46);
            label1.TabIndex = 0;
            label1.Text = "THÊM MÓN ĂN";
            // 
            // textBox_Ten
            // 
            textBox_Ten.BorderStyle = BorderStyle.FixedSingle;
            textBox_Ten.Location = new Point(134, 116);
            textBox_Ten.Name = "textBox_Ten";
            textBox_Ten.Size = new Size(246, 27);
            textBox_Ten.TabIndex = 1;
            // 
            // richTextBox_Mota
            // 
            richTextBox_Mota.BorderStyle = BorderStyle.FixedSingle;
            richTextBox_Mota.Location = new Point(134, 290);
            richTextBox_Mota.Name = "richTextBox_Mota";
            richTextBox_Mota.Size = new Size(246, 109);
            richTextBox_Mota.TabIndex = 5;
            richTextBox_Mota.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 119);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên món ăn:";
            // 
            // button_them
            // 
            button_them.Location = new Point(286, 415);
            button_them.Name = "button_them";
            button_them.Size = new Size(94, 42);
            button_them.TabIndex = 6;
            button_them.Text = "Thêm";
            button_them.UseVisualStyleBackColor = true;
            button_them.Click += button_them_Click;
            // 
            // textBox_Gia
            // 
            textBox_Gia.BorderStyle = BorderStyle.FixedSingle;
            textBox_Gia.Location = new Point(134, 160);
            textBox_Gia.Name = "textBox_Gia";
            textBox_Gia.Size = new Size(246, 27);
            textBox_Gia.TabIndex = 2;
            // 
            // textBox_HinhAnh
            // 
            textBox_HinhAnh.BorderStyle = BorderStyle.FixedSingle;
            textBox_HinhAnh.Location = new Point(134, 250);
            textBox_HinhAnh.Name = "textBox_HinhAnh";
            textBox_HinhAnh.Size = new Size(246, 27);
            textBox_HinhAnh.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 167);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 8;
            label3.Text = "Giá:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 215);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 9;
            label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 257);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 10;
            label5.Text = "Hình Ảnh:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 290);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 11;
            label6.Text = "Mô tả:";
            // 
            // button_clear
            // 
            button_clear.Location = new Point(171, 415);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(94, 42);
            button_clear.TabIndex = 12;
            button_clear.Text = "Làm mới";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // textBox_Diachi
            // 
            textBox_Diachi.BorderStyle = BorderStyle.FixedSingle;
            textBox_Diachi.Location = new Point(134, 208);
            textBox_Diachi.Name = "textBox_Diachi";
            textBox_Diachi.Size = new Size(246, 27);
            textBox_Diachi.TabIndex = 3;
            // 
            // ThemMonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 479);
            Controls.Add(button_clear);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox_HinhAnh);
            Controls.Add(textBox_Diachi);
            Controls.Add(textBox_Gia);
            Controls.Add(button_them);
            Controls.Add(label2);
            Controls.Add(richTextBox_Mota);
            Controls.Add(textBox_Ten);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ThemMonAn";
            Text = "Thêm Món Ăn";
            FormClosed += ThemMonAn_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_Ten;
        private RichTextBox richTextBox_Mota;
        private Label label2;
        private Button button_them;
        private TextBox textBox_Gia;
        private TextBox textBox_HinhAnh;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button_clear;
        private TextBox textBox_Diachi;
    }
}