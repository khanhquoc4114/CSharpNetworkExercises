namespace Lab02
{
    partial class Bai6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai6));
            monAnBindingSource = new BindingSource(components);
            nguoiDungBindingSource = new BindingSource(components);
            listView1 = new ListView();
            button1 = new Button();
            textBox_kq = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
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
            // listView1
            // 
            listView1.Location = new Point(560, 21);
            listView1.Name = "listView1";
            listView1.Size = new Size(216, 143);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
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
            pictureBox1.Size = new Size(411, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(835, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(textBox_kq);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "Bai6";
            Text = "Bài 6";
            ((System.ComponentModel.ISupportInitialize)monAnBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nguoiDungBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource monAnBindingSource;
        private BindingSource nguoiDungBindingSource;
        private ListView listView1;
        private ImageList imageList1;
        private Button button1;
        private TextBox textBox_kq;
        private Label label1;
        private PictureBox pictureBox1;
    }
}