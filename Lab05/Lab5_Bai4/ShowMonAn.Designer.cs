﻿namespace Lab4_Bai7
{
    partial class ShowMonAn
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
            pictureBoxHinhAnh = new PictureBox();
            labelId = new Label();
            labelTenMonAn = new Label();
            labelGia = new Label();
            labelDiaChi = new Label();
            labelNguoiDongGop = new Label();
            button_moibanbe = new Button();
            isconnectedlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxHinhAnh
            // 
            pictureBoxHinhAnh.Location = new Point(0, 0);
            pictureBoxHinhAnh.Name = "pictureBoxHinhAnh";
            pictureBoxHinhAnh.Size = new Size(258, 221);
            pictureBoxHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHinhAnh.TabIndex = 0;
            pictureBoxHinhAnh.TabStop = false;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(282, 9);
            labelId.Name = "labelId";
            labelId.Size = new Size(50, 20);
            labelId.TabIndex = 1;
            labelId.Text = "label1";
            // 
            // labelTenMonAn
            // 
            labelTenMonAn.AutoSize = true;
            labelTenMonAn.Location = new Point(282, 49);
            labelTenMonAn.Name = "labelTenMonAn";
            labelTenMonAn.Size = new Size(50, 20);
            labelTenMonAn.TabIndex = 2;
            labelTenMonAn.Text = "label2";
            // 
            // labelGia
            // 
            labelGia.AutoSize = true;
            labelGia.Location = new Point(282, 89);
            labelGia.Name = "labelGia";
            labelGia.Size = new Size(50, 20);
            labelGia.TabIndex = 3;
            labelGia.Text = "label3";
            // 
            // labelDiaChi
            // 
            labelDiaChi.AutoSize = true;
            labelDiaChi.Location = new Point(282, 134);
            labelDiaChi.Name = "labelDiaChi";
            labelDiaChi.Size = new Size(50, 20);
            labelDiaChi.TabIndex = 4;
            labelDiaChi.Text = "label4";
            // 
            // labelNguoiDongGop
            // 
            labelNguoiDongGop.AutoSize = true;
            labelNguoiDongGop.Location = new Point(282, 171);
            labelNguoiDongGop.Name = "labelNguoiDongGop";
            labelNguoiDongGop.Size = new Size(50, 20);
            labelNguoiDongGop.TabIndex = 5;
            labelNguoiDongGop.Text = "label5";
            // 
            // button_moibanbe
            // 
            button_moibanbe.Location = new Point(430, 223);
            button_moibanbe.Name = "button_moibanbe";
            button_moibanbe.Size = new Size(110, 29);
            button_moibanbe.TabIndex = 6;
            button_moibanbe.Text = "Mời bạn bè ";
            button_moibanbe.UseVisualStyleBackColor = true;
            button_moibanbe.Click += button_moibanbe_Click;
            // 
            // isconnectedlabel
            // 
            isconnectedlabel.AutoSize = true;
            isconnectedlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            isconnectedlabel.Location = new Point(12, 232);
            isconnectedlabel.Name = "isconnectedlabel";
            isconnectedlabel.Size = new Size(51, 20);
            isconnectedlabel.TabIndex = 7;
            isconnectedlabel.Text = "label1";
            // 
            // ShowMonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 264);
            Controls.Add(isconnectedlabel);
            Controls.Add(button_moibanbe);
            Controls.Add(labelNguoiDongGop);
            Controls.Add(labelDiaChi);
            Controls.Add(labelGia);
            Controls.Add(labelTenMonAn);
            Controls.Add(labelId);
            Controls.Add(pictureBoxHinhAnh);
            Name = "ShowMonAn";
            Text = "Đi ăn đi";
            ((System.ComponentModel.ISupportInitialize)pictureBoxHinhAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxHinhAnh;
        private Label labelId;
        private Label labelTenMonAn;
        private Label labelGia;
        private Label labelDiaChi;
        private Label labelNguoiDongGop;
        private Button button_moibanbe;
        private Label isconnectedlabel;
    }
}