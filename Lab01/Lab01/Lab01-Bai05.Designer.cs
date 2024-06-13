namespace Lab01
{
    partial class Bai5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai5));
            button_tinh = new Button();
            label_nhapa = new Label();
            label_nhapb = new Label();
            comboBox1 = new ComboBox();
            button_xoa = new Button();
            richTextBox1 = new RichTextBox();
            textBox_nhapa = new TextBox();
            textBox_nhapb = new TextBox();
            label_ketqua = new Label();
            SuspendLayout();
            // 
            // button_tinh
            // 
            button_tinh.Location = new Point(88, 199);
            button_tinh.Name = "button_tinh";
            button_tinh.Size = new Size(141, 45);
            button_tinh.TabIndex = 0;
            button_tinh.Text = "Tính các giá trị";
            button_tinh.UseVisualStyleBackColor = true;
            button_tinh.Click += buttontinh_Click;
            // 
            // label_nhapa
            // 
            label_nhapa.AutoSize = true;
            label_nhapa.Location = new Point(88, 31);
            label_nhapa.Name = "label_nhapa";
            label_nhapa.Size = new Size(59, 20);
            label_nhapa.TabIndex = 1;
            label_nhapa.Text = "Nhập A";
            // 
            // label_nhapb
            // 
            label_nhapb.AutoSize = true;
            label_nhapb.Location = new Point(473, 31);
            label_nhapb.Name = "label_nhapb";
            label_nhapb.Size = new Size(58, 20);
            label_nhapb.TabIndex = 2;
            label_nhapb.Text = "Nhập B";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bảng cửu chương", "Tính toán giá trị" });
            comboBox1.Location = new Point(303, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(88, 272);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(141, 45);
            button_xoa.TabIndex = 4;
            button_xoa.Text = "Xoá";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += buttonxoa_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(489, 172);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(256, 223);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // textBox_nhapa
            // 
            textBox_nhapa.Location = new Point(153, 28);
            textBox_nhapa.Name = "textBox_nhapa";
            textBox_nhapa.Size = new Size(125, 27);
            textBox_nhapa.TabIndex = 6;
            // 
            // textBox_nhapb
            // 
            textBox_nhapb.Location = new Point(537, 24);
            textBox_nhapb.Name = "textBox_nhapb";
            textBox_nhapb.Size = new Size(125, 27);
            textBox_nhapb.TabIndex = 7;
            // 
            // label_ketqua
            // 
            label_ketqua.AutoSize = true;
            label_ketqua.Location = new Point(489, 149);
            label_ketqua.Name = "label_ketqua";
            label_ketqua.Size = new Size(60, 20);
            label_ketqua.TabIndex = 8;
            label_ketqua.Text = "Kết quả";
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label_ketqua);
            Controls.Add(textBox_nhapb);
            Controls.Add(textBox_nhapa);
            Controls.Add(richTextBox1);
            Controls.Add(button_xoa);
            Controls.Add(comboBox1);
            Controls.Add(label_nhapb);
            Controls.Add(label_nhapa);
            Controls.Add(button_tinh);
            Name = "Bai5";
            Text = "Bai5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_tinh;
        private Label label_nhapa;
        private Label label_nhapb;
        private ComboBox comboBox1;
        private Button button_xoa;
        private RichTextBox richTextBox1;
        private TextBox textBox_nhapa;
        private TextBox textBox_nhapb;
        private Label label_ketqua;
    }
}