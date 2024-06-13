namespace Lab01
{
    partial class Bai7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai7));
            button_xet = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label_ten = new Label();
            textBox_ten = new TextBox();
            textBox_class = new TextBox();
            label_xeploai = new Label();
            label_vidu = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_xet
            // 
            button_xet.Location = new Point(332, 104);
            button_xet.Name = "button_xet";
            button_xet.Size = new Size(138, 44);
            button_xet.TabIndex = 0;
            button_xet.Text = "Xét";
            button_xet.UseVisualStyleBackColor = true;
            button_xet.Click += buttonxet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 63);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhập";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(371, 27);
            textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(668, 218);
            dataGridView1.TabIndex = 3;
            // 
            // label_ten
            // 
            label_ten.AutoSize = true;
            label_ten.Location = new Point(65, 173);
            label_ten.Name = "label_ten";
            label_ten.Size = new Size(32, 20);
            label_ten.TabIndex = 4;
            label_ten.Text = "Tên";
            // 
            // textBox_ten
            // 
            textBox_ten.Location = new Point(103, 166);
            textBox_ten.Name = "textBox_ten";
            textBox_ten.ReadOnly = true;
            textBox_ten.Size = new Size(174, 27);
            textBox_ten.TabIndex = 5;
            // 
            // textBox_class
            // 
            textBox_class.Location = new Point(353, 166);
            textBox_class.Name = "textBox_class";
            textBox_class.ReadOnly = true;
            textBox_class.Size = new Size(125, 27);
            textBox_class.TabIndex = 6;
            // 
            // label_xeploai
            // 
            label_xeploai.AutoSize = true;
            label_xeploai.Location = new Point(283, 166);
            label_xeploai.Name = "label_xeploai";
            label_xeploai.Size = new Size(64, 20);
            label_xeploai.TabIndex = 7;
            label_xeploai.Text = "Xếp loại";
            // 
            // label_vidu
            // 
            label_vidu.AutoSize = true;
            label_vidu.Location = new Point(504, 9);
            label_vidu.Name = "label_vidu";
            label_vidu.Size = new Size(43, 20);
            label_vidu.TabIndex = 8;
            label_vidu.Text = "Ví dụ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(553, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 27);
            textBox2.TabIndex = 9;
            textBox2.Text = "Nguyễn Văn A, 10, 4";
            // 
            // Bai7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label_vidu);
            Controls.Add(label_xeploai);
            Controls.Add(textBox_class);
            Controls.Add(textBox_ten);
            Controls.Add(label_ten);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button_xet);
            Name = "Bai7";
            Text = "Bai7";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_xet;
        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label_ten;
        private TextBox textBox_ten;
        private TextBox textBox_class;
        private Label label_xeploai;
        private Label label_vidu;
        private TextBox textBox2;
    }
}