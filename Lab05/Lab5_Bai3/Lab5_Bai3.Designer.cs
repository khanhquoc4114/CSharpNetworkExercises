namespace Lab02
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
            comboBox_phim = new ComboBox();
            comboBox_rap = new ComboBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            label_phim = new Label();
            label_rap = new Label();
            label_email = new Label();
            textBox_email = new TextBox();
            button_thanhtoan = new Button();
            button_import = new Button();
            button_statistic = new Button();
            label1 = new Label();
            textBox_ten = new TextBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox_phim
            // 
            comboBox_phim.FormattingEnabled = true;
            comboBox_phim.Location = new Point(69, 11);
            comboBox_phim.Margin = new Padding(3, 2, 3, 2);
            comboBox_phim.Name = "comboBox_phim";
            comboBox_phim.Size = new Size(189, 23);
            comboBox_phim.TabIndex = 0;
            comboBox_phim.SelectedIndexChanged += comboBox_phim_SelectedIndexChanged;
            // 
            // comboBox_rap
            // 
            comboBox_rap.FormattingEnabled = true;
            comboBox_rap.Location = new Point(69, 38);
            comboBox_rap.Margin = new Padding(3, 2, 3, 2);
            comboBox_rap.Name = "comboBox_rap";
            comboBox_rap.Size = new Size(116, 23);
            comboBox_rap.TabIndex = 1;
            comboBox_rap.SelectedIndexChanged += comboBox_rap_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Location = new Point(20, 65);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(446, 241);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ghế";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.Location = new Point(472, 133);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(324, 149);
            dataGridView1.TabIndex = 3;
            // 
            // label_phim
            // 
            label_phim.AutoSize = true;
            label_phim.Location = new Point(20, 17);
            label_phim.Name = "label_phim";
            label_phim.Size = new Size(35, 15);
            label_phim.TabIndex = 4;
            label_phim.Text = "Phim";
            // 
            // label_rap
            // 
            label_rap.AutoSize = true;
            label_rap.Location = new Point(20, 41);
            label_rap.Name = "label_rap";
            label_rap.Size = new Size(27, 15);
            label_rap.TabIndex = 5;
            label_rap.Text = "Rạp";
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new Point(8, 21);
            label_email.Name = "label_email";
            label_email.Size = new Size(68, 15);
            label_email.TabIndex = 6;
            label_email.Text = "Nhập email";
            // 
            // textBox_email
            // 
            textBox_email.BorderStyle = BorderStyle.FixedSingle;
            textBox_email.Location = new Point(89, 21);
            textBox_email.Margin = new Padding(3, 2, 3, 2);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(205, 23);
            textBox_email.TabIndex = 7;
            // 
            // button_thanhtoan
            // 
            button_thanhtoan.Location = new Point(716, 286);
            button_thanhtoan.Margin = new Padding(3, 2, 3, 2);
            button_thanhtoan.Name = "button_thanhtoan";
            button_thanhtoan.Size = new Size(80, 24);
            button_thanhtoan.TabIndex = 8;
            button_thanhtoan.Text = "Thanh toán";
            button_thanhtoan.UseVisualStyleBackColor = true;
            button_thanhtoan.Click += button_thanhtoan_Click;
            // 
            // button_import
            // 
            button_import.Location = new Point(586, 11);
            button_import.Margin = new Padding(3, 2, 3, 2);
            button_import.Name = "button_import";
            button_import.Size = new Size(82, 28);
            button_import.TabIndex = 0;
            button_import.Text = "Import";
            button_import.UseVisualStyleBackColor = true;
            button_import.Click += button_import_Click;
            // 
            // button_statistic
            // 
            button_statistic.Location = new Point(674, 11);
            button_statistic.Margin = new Padding(3, 2, 3, 2);
            button_statistic.Name = "button_statistic";
            button_statistic.Size = new Size(122, 28);
            button_statistic.TabIndex = 9;
            button_statistic.Text = "Statistic_export";
            button_statistic.UseVisualStyleBackColor = true;
            button_statistic.Click += button_static_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 53);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 10;
            label1.Text = "Nhập tên";
            // 
            // textBox_ten
            // 
            textBox_ten.BorderStyle = BorderStyle.FixedSingle;
            textBox_ten.Location = new Point(89, 52);
            textBox_ten.Margin = new Padding(3, 2, 3, 2);
            textBox_ten.Name = "textBox_ten";
            textBox_ten.Size = new Size(205, 23);
            textBox_ten.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox_ten);
            groupBox2.Controls.Add(textBox_email);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label_email);
            groupBox2.Location = new Point(493, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(303, 84);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Info";
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(802, 317);
            Controls.Add(groupBox2);
            Controls.Add(button_statistic);
            Controls.Add(button_import);
            Controls.Add(button_thanhtoan);
            Controls.Add(label_rap);
            Controls.Add(label_phim);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(comboBox_rap);
            Controls.Add(comboBox_phim);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Bai3";
            Text = "Rạp phim";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Label label_email;
        private TextBox textBox_email;
        private Button button_thanhtoan;
        private Button button_import;
        private Button button_statistic;
        private Label label1;
        private TextBox textBox_ten;
        private GroupBox groupBox2;
    }
}