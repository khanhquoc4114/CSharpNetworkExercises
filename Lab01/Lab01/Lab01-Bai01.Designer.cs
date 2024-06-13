namespace Lab01
{
    partial class Bai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai1));
            textBox_songuyen1 = new TextBox();
            textBox_songuyen2 = new TextBox();
            textBox_ketqua = new TextBox();
            label_songuyen1 = new Label();
            label_songuyen2 = new Label();
            label_ketqua = new Label();
            button_tinh = new Button();
            SuspendLayout();
            // 
            // textBox_songuyen1
            // 
            textBox_songuyen1.Location = new Point(311, 64);
            textBox_songuyen1.Name = "textBox_songuyen1";
            textBox_songuyen1.Size = new Size(125, 27);
            textBox_songuyen1.TabIndex = 0;
            textBox_songuyen1.TextChanged += songuyen1_TextChanged;
            // 
            // textBox_songuyen2
            // 
            textBox_songuyen2.Location = new Point(311, 114);
            textBox_songuyen2.Name = "textBox_songuyen2";
            textBox_songuyen2.Size = new Size(125, 27);
            textBox_songuyen2.TabIndex = 1;
            textBox_songuyen2.TextChanged += songuyen2_TextChanged;
            // 
            // textBox_ketqua
            // 
            textBox_ketqua.Location = new Point(311, 166);
            textBox_ketqua.Name = "textBox_ketqua";
            textBox_ketqua.ReadOnly = true;
            textBox_ketqua.Size = new Size(125, 27);
            textBox_ketqua.TabIndex = 2;
            textBox_ketqua.TextChanged += ketqua_TextChanged;
            // 
            // label_songuyen1
            // 
            label_songuyen1.AutoSize = true;
            label_songuyen1.Location = new Point(216, 64);
            label_songuyen1.Name = "label_songuyen1";
            label_songuyen1.Size = new Size(90, 20);
            label_songuyen1.TabIndex = 3;
            label_songuyen1.Text = "Số nguyên 1";
            // 
            // label_songuyen2
            // 
            label_songuyen2.AutoSize = true;
            label_songuyen2.Location = new Point(216, 113);
            label_songuyen2.Name = "label_songuyen2";
            label_songuyen2.Size = new Size(90, 20);
            label_songuyen2.TabIndex = 4;
            label_songuyen2.Text = "Số nguyên 2";
            // 
            // label_ketqua
            // 
            label_ketqua.AutoSize = true;
            label_ketqua.Location = new Point(216, 166);
            label_ketqua.Name = "label_ketqua";
            label_ketqua.Size = new Size(60, 20);
            label_ketqua.TabIndex = 5;
            label_ketqua.Text = "Kết quả";
            // 
            // button_tinh
            // 
            button_tinh.Location = new Point(505, 61);
            button_tinh.Name = "button_tinh";
            button_tinh.Size = new Size(94, 72);
            button_tinh.TabIndex = 6;
            button_tinh.Text = "Tính";
            button_tinh.UseVisualStyleBackColor = true;
            button_tinh.Click += button_tinh_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button_tinh);
            Controls.Add(label_ketqua);
            Controls.Add(label_songuyen2);
            Controls.Add(label_songuyen1);
            Controls.Add(textBox_ketqua);
            Controls.Add(textBox_songuyen2);
            Controls.Add(textBox_songuyen1);
            Name = "Bai1";
            Text = "Bai1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_songuyen1;
        private TextBox textBox_songuyen2;
        private TextBox textBox_ketqua;
        private Label label_songuyen1;
        private Label label_songuyen2;
        private Label label_ketqua;
        private Button button_tinh;
    }
}