namespace Lab01
{
    partial class Bai8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai8));
            listBox1 = new ListBox();
            label_nhap = new Label();
            label_show = new Label();
            textBox_nhap = new TextBox();
            button_them = new Button();
            button_xoa = new Button();
            button3 = new Button();
            button_tim = new Button();
            textBox_show = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(521, 61);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(267, 184);
            listBox1.TabIndex = 0;
            // 
            // label_nhap
            // 
            label_nhap.AutoSize = true;
            label_nhap.Location = new Point(87, 61);
            label_nhap.Name = "label_nhap";
            label_nhap.Size = new Size(99, 20);
            label_nhap.TabIndex = 1;
            label_nhap.Text = "Nhập món ăn";
            // 
            // label_show
            // 
            label_show.AutoSize = true;
            label_show.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_show.Location = new Point(329, 316);
            label_show.Name = "label_show";
            label_show.Size = new Size(180, 28);
            label_show.TabIndex = 2;
            label_show.Text = "Món ăn hôm nay là";
            // 
            // textBox_nhap
            // 
            textBox_nhap.Location = new Point(192, 61);
            textBox_nhap.Name = "textBox_nhap";
            textBox_nhap.Size = new Size(256, 27);
            textBox_nhap.TabIndex = 3;
            // 
            // button_them
            // 
            button_them.Location = new Point(354, 112);
            button_them.Name = "button_them";
            button_them.Size = new Size(94, 46);
            button_them.TabIndex = 4;
            button_them.Text = "Thêm";
            button_them.UseVisualStyleBackColor = true;
            button_them.Click += button_them_Click;
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(354, 199);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(94, 46);
            button_xoa.TabIndex = 5;
            button_xoa.Text = "Xoá";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // button3
            // 
            button3.Location = new Point(363, 347);
            button3.Name = "button3";
            button3.Size = new Size(8, 8);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button_tim
            // 
            button_tim.Location = new Point(192, 199);
            button_tim.Name = "button_tim";
            button_tim.Size = new Size(114, 46);
            button_tim.TabIndex = 7;
            button_tim.Text = "Tìm món ăn";
            button_tim.UseVisualStyleBackColor = true;
            button_tim.Click += button_tim_Click;
            // 
            // textBox_show
            // 
            textBox_show.Location = new Point(329, 361);
            textBox_show.Name = "textBox_show";
            textBox_show.Size = new Size(180, 27);
            textBox_show.TabIndex = 8;
            // 
            // Bai8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_show);
            Controls.Add(button_tim);
            Controls.Add(button3);
            Controls.Add(button_xoa);
            Controls.Add(button_them);
            Controls.Add(textBox_nhap);
            Controls.Add(label_show);
            Controls.Add(label_nhap);
            Controls.Add(listBox1);
            Name = "Bai8";
            Text = "Bai8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label_nhap;
        private Label label_show;
        private TextBox textBox_nhap;
        private Button button_them;
        private Button button_xoa;
        private Button button3;
        private Button button_tim;
        private TextBox textBox_show;
    }
}