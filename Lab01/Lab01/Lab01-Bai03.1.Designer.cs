namespace Lab01
{
    partial class Bai3_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai3_1));
            textBox_kq = new TextBox();
            textBox_nhap = new TextBox();
            label_ketqua = new Label();
            label_nhap = new Label();
            button_xoa = new Button();
            button_doc = new Button();
            SuspendLayout();
            // 
            // textBox_kq
            // 
            textBox_kq.Location = new Point(150, 307);
            textBox_kq.Multiline = true;
            textBox_kq.Name = "textBox_kq";
            textBox_kq.ReadOnly = true;
            textBox_kq.Size = new Size(358, 81);
            textBox_kq.TabIndex = 11;
            // 
            // textBox_nhap
            // 
            textBox_nhap.Location = new Point(166, 132);
            textBox_nhap.Name = "textBox_nhap";
            textBox_nhap.Size = new Size(209, 27);
            textBox_nhap.TabIndex = 10;
            // 
            // label_ketqua
            // 
            label_ketqua.AutoSize = true;
            label_ketqua.Location = new Point(166, 263);
            label_ketqua.Name = "label_ketqua";
            label_ketqua.Size = new Size(60, 20);
            label_ketqua.TabIndex = 9;
            label_ketqua.Text = "Kết quả";
            // 
            // label_nhap
            // 
            label_nhap.AutoSize = true;
            label_nhap.Location = new Point(166, 97);
            label_nhap.Name = "label_nhap";
            label_nhap.Size = new Size(251, 20);
            label_nhap.TabIndex = 8;
            label_nhap.Text = "Nhập số nguyên 12 chữ số trở xuống";
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(540, 263);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(94, 55);
            button_xoa.TabIndex = 7;
            button_xoa.Text = "Xoá";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // button_doc
            // 
            button_doc.Location = new Point(540, 163);
            button_doc.Name = "button_doc";
            button_doc.Size = new Size(94, 55);
            button_doc.TabIndex = 6;
            button_doc.Text = "Đọc";
            button_doc.UseVisualStyleBackColor = true;
            button_doc.Click += button_doc_Click;
            // 
            // Bai3_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_kq);
            Controls.Add(textBox_nhap);
            Controls.Add(label_ketqua);
            Controls.Add(label_nhap);
            Controls.Add(button_xoa);
            Controls.Add(button_doc);
            Name = "Bai3_1";
            Text = "Bai3.1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_kq;
        private TextBox textBox_nhap;
        private Label label_ketqua;
        private Label label_nhap;
        private Button button_xoa;
        private Button button_doc;
    }
}