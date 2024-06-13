namespace Lab02
{
    partial class mainForm
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
            components = new System.ComponentModel.Container();
            ImageList imageList1;
            monAnBindingSource = new BindingSource(components);
            nguoiDungBindingSource = new BindingSource(components);
            button1 = new Button();
            textBox_kq = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            button_chung = new Button();
            button_rieng = new Button();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)monAnBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nguoiDungBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // monAnBindingSource
            // 
            monAnBindingSource.DataSource = typeof(MonAn);
            // 
            // nguoiDungBindingSource
            // 
            nguoiDungBindingSource.DataSource = typeof(NguoiDung);
            // 
            // button1
            // 
            button1.Location = new Point(356, 387);
            button1.Name = "button1";
            button1.Size = new Size(116, 51);
            button1.TabIndex = 1;
            button1.Text = "Chọn món ngẫu nhiên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_random_Click;
            // 
            // textBox_kq
            // 
            textBox_kq.Location = new Point(264, 342);
            textBox_kq.Name = "textBox_kq";
            textBox_kq.Size = new Size(342, 27);
            textBox_kq.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 345);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Món ăn là";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(61, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(382, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(542, 31);
            listView1.Name = "listView1";
            listView1.Size = new Size(239, 191);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Tile;
            // 
            // button_chung
            // 
            button_chung.Location = new Point(569, 251);
            button_chung.Name = "button_chung";
            button_chung.Size = new Size(85, 70);
            button_chung.TabIndex = 7;
            button_chung.Text = "db chung";
            button_chung.UseVisualStyleBackColor = true;
            button_chung.Click += button_chung_Click;
            // 
            // button_rieng
            // 
            button_rieng.Location = new Point(681, 251);
            button_rieng.Name = "button_rieng";
            button_rieng.Size = new Size(85, 70);
            button_rieng.TabIndex = 8;
            button_rieng.Text = "db riêng";
            button_rieng.UseVisualStyleBackColor = true;
            button_rieng.Click += button_rieng_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(835, 450);
            Controls.Add(button_rieng);
            Controls.Add(button_chung);
            Controls.Add(listView1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(textBox_kq);
            Controls.Add(button1);
            Name = "mainForm";
            Text = "Bài 6";
            Activated += mainForm_Activated;
            ((System.ComponentModel.ISupportInitialize)monAnBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nguoiDungBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource monAnBindingSource;
        private BindingSource nguoiDungBindingSource;
        private ImageList imageList1;
        private Button button1;
        private TextBox textBox_kq;
        private Label label1;
        private PictureBox pictureBox1;
        private ListView listView1;
        private Button button_chung;
        private Button button_rieng;
    }
}