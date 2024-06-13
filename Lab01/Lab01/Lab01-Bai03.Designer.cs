namespace Lab01
{
    partial class Bai3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai3));
            button_doc = new Button();
            button_xoa = new Button();
            label_nhap = new Label();
            label_ketqua = new Label();
            textBox_nhap = new TextBox();
            textBox_kq = new TextBox();
            SuspendLayout();
            // 
            // button_doc
            // 
            button_doc.Location = new Point(571, 99);
            button_doc.Name = "button_doc";
            button_doc.Size = new Size(94, 55);
            button_doc.TabIndex = 0;
            button_doc.Text = "Đọc";
            button_doc.UseVisualStyleBackColor = true;
            button_doc.Click += button_doc_Click;
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(571, 199);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(94, 55);
            button_xoa.TabIndex = 1;
            button_xoa.Text = "Xoá";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // label_nhap
            // 
            label_nhap.AutoSize = true;
            label_nhap.Location = new Point(197, 71);
            label_nhap.Name = "label_nhap";
            label_nhap.Size = new Size(191, 20);
            label_nhap.TabIndex = 2;
            label_nhap.Text = "Nhập số nguyên từ 0 đến 9 ";
            // 
            // label_ketqua
            // 
            label_ketqua.AutoSize = true;
            label_ketqua.Location = new Point(197, 199);
            label_ketqua.Name = "label_ketqua";
            label_ketqua.Size = new Size(60, 20);
            label_ketqua.TabIndex = 3;
            label_ketqua.Text = "Kết quả";
            // 
            // textBox_nhap
            // 
            textBox_nhap.Location = new Point(394, 68);
            textBox_nhap.Name = "textBox_nhap";
            textBox_nhap.Size = new Size(125, 27);
            textBox_nhap.TabIndex = 4;
            // 
            // textBox_kq
            // 
            textBox_kq.Location = new Point(197, 227);
            textBox_kq.Name = "textBox_kq";
            textBox_kq.ReadOnly = true;
            textBox_kq.Size = new Size(209, 27);
            textBox_kq.TabIndex = 5;
            // 
            // Bai3
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
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_doc;
        private Button button_xoa;
        private Label label_nhap;
        private Label label_ketqua;
        private TextBox textBox_nhap;
        private TextBox textBox_kq;
    }
}