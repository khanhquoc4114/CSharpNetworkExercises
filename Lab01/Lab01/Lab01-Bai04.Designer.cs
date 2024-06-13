namespace Lab01
{
    partial class Bai4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai4));
            comboBox_phim = new ComboBox();
            comboBox_rap = new ComboBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            label_phim = new Label();
            label_rap = new Label();
            label_ten = new Label();
            textBox_ten = new TextBox();
            button_thanhtoan = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox_phim
            // 
            comboBox_phim.FormattingEnabled = true;
            comboBox_phim.Items.AddRange(new object[] { "Đào, phở và piano", "Mai", "Gặp lại chị bầu", "Tarot" });
            comboBox_phim.Location = new Point(135, 47);
            comboBox_phim.Name = "comboBox_phim";
            comboBox_phim.Size = new Size(215, 28);
            comboBox_phim.TabIndex = 0;
            comboBox_phim.SelectedIndexChanged += comboBox_phim_SelectedIndexChanged;
            // 
            // comboBox_rap
            // 
            comboBox_rap.FormattingEnabled = true;
            comboBox_rap.Items.AddRange(new object[] { "Phòng chiếu 1", "Phòng chiếu 2", "Phòng chiếu 3" });
            comboBox_rap.Location = new Point(135, 95);
            comboBox_rap.Name = "comboBox_rap";
            comboBox_rap.Size = new Size(132, 28);
            comboBox_rap.TabIndex = 1;
            comboBox_rap.SelectedIndexChanged += comboBox_rap_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Location = new Point(79, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 261);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.Location = new Point(520, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(370, 199);
            dataGridView1.TabIndex = 3;
            // 
            // label_phim
            // 
            label_phim.AutoSize = true;
            label_phim.Location = new Point(79, 55);
            label_phim.Name = "label_phim";
            label_phim.Size = new Size(42, 20);
            label_phim.TabIndex = 4;
            label_phim.Text = "Phim";
            // 
            // label_rap
            // 
            label_rap.AutoSize = true;
            label_rap.Location = new Point(79, 98);
            label_rap.Name = "label_rap";
            label_rap.Size = new Size(35, 20);
            label_rap.TabIndex = 5;
            label_rap.Text = "Rạp";
            // 
            // label_ten
            // 
            label_ten.AutoSize = true;
            label_ten.Location = new Point(520, 114);
            label_ten.Name = "label_ten";
            label_ten.Size = new Size(70, 20);
            label_ten.TabIndex = 6;
            label_ten.Text = "Nhập tên";
            // 
            // textBox_ten
            // 
            textBox_ten.Location = new Point(596, 111);
            textBox_ten.Name = "textBox_ten";
            textBox_ten.Size = new Size(234, 27);
            textBox_ten.TabIndex = 7;
            // 
            // button_thanhtoan
            // 
            button_thanhtoan.Location = new Point(798, 369);
            button_thanhtoan.Name = "button_thanhtoan";
            button_thanhtoan.Size = new Size(92, 32);
            button_thanhtoan.TabIndex = 8;
            button_thanhtoan.Text = "Thanh toán";
            button_thanhtoan.UseVisualStyleBackColor = true;
            button_thanhtoan.Click += button_thanhtoan_Click;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(923, 450);
            Controls.Add(button_thanhtoan);
            Controls.Add(textBox_ten);
            Controls.Add(label_ten);
            Controls.Add(label_rap);
            Controls.Add(label_phim);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(comboBox_rap);
            Controls.Add(comboBox_phim);
            Name = "Bai4";
            Text = "Bai4";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_phim;
        private ComboBox comboBox_rap;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label label_phim;
        private Label label_rap;
        private Label label_ten;
        private TextBox textBox_ten;
        private Button button_thanhtoan;
    }
}