namespace Lab4_Bai7
{
    partial class MainForm
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
            tabControl = new TabControl();
            tabPage_All = new TabPage();
            dataGridView_All = new DataGridView();
            tabPage_Me = new TabPage();
            dataGridView_Me = new DataGridView();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox_page = new ComboBox();
            comboBox_pagesize = new ComboBox();
            button_angigio = new Button();
            button_themmonan = new Button();
            label_name = new Label();
            button_delete = new Button();
            tabControl.SuspendLayout();
            tabPage_All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_All).BeginInit();
            tabPage_Me.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Me).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage_All);
            tabControl.Controls.Add(tabPage_Me);
            tabControl.Location = new Point(8, 85);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(669, 450);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabPage_All
            // 
            tabPage_All.Controls.Add(dataGridView_All);
            tabPage_All.Location = new Point(4, 29);
            tabPage_All.Name = "tabPage_All";
            tabPage_All.Padding = new Padding(3);
            tabPage_All.Size = new Size(661, 417);
            tabPage_All.TabIndex = 0;
            tabPage_All.Text = "All";
            tabPage_All.UseVisualStyleBackColor = true;
            // 
            // dataGridView_All
            // 
            dataGridView_All.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_All.Dock = DockStyle.Fill;
            dataGridView_All.Location = new Point(3, 3);
            dataGridView_All.Name = "dataGridView_All";
            dataGridView_All.RowHeadersWidth = 51;
            dataGridView_All.Size = new Size(655, 411);
            dataGridView_All.TabIndex = 0;
            // 
            // tabPage_Me
            // 
            tabPage_Me.Controls.Add(dataGridView_Me);
            tabPage_Me.Location = new Point(4, 29);
            tabPage_Me.Name = "tabPage_Me";
            tabPage_Me.Padding = new Padding(3);
            tabPage_Me.Size = new Size(661, 417);
            tabPage_Me.TabIndex = 1;
            tabPage_Me.Text = "Tôi đóng góp";
            tabPage_Me.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Me
            // 
            dataGridView_Me.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Me.Dock = DockStyle.Fill;
            dataGridView_Me.Location = new Point(3, 3);
            dataGridView_Me.Name = "dataGridView_Me";
            dataGridView_Me.RowHeadersWidth = 51;
            dataGridView_Me.Size = new Size(655, 411);
            dataGridView_Me.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(251, 542);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(163, 21);
            progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(287, 46);
            label1.TabIndex = 0;
            label1.Text = "HÔM NAY ĂN GÌ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(452, 545);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 2;
            label2.Text = "Page";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 545);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Page size";
            // 
            // comboBox_page
            // 
            comboBox_page.FormattingEnabled = true;
            comboBox_page.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            comboBox_page.Location = new Point(501, 542);
            comboBox_page.Name = "comboBox_page";
            comboBox_page.Size = new Size(45, 28);
            comboBox_page.TabIndex = 4;
            comboBox_page.Text = "1";
            comboBox_page.SelectedIndexChanged += comboBox_page_SelectedIndexChanged;
            // 
            // comboBox_pagesize
            // 
            comboBox_pagesize.FormattingEnabled = true;
            comboBox_pagesize.Items.AddRange(new object[] { "5", "10", "15", "20", "25" });
            comboBox_pagesize.Location = new Point(628, 542);
            comboBox_pagesize.Name = "comboBox_pagesize";
            comboBox_pagesize.Size = new Size(45, 28);
            comboBox_pagesize.TabIndex = 5;
            comboBox_pagesize.Text = "5";
            comboBox_pagesize.SelectedIndexChanged += comboBox_pagesize_SelectedIndexChanged;
            // 
            // button_angigio
            // 
            button_angigio.Location = new Point(264, 66);
            button_angigio.Name = "button_angigio";
            button_angigio.Size = new Size(126, 45);
            button_angigio.TabIndex = 6;
            button_angigio.Text = "Ăn gì giờ ?";
            button_angigio.UseVisualStyleBackColor = true;
            button_angigio.Click += button_angigio_Click;
            // 
            // button_themmonan
            // 
            button_themmonan.Location = new Point(406, 66);
            button_themmonan.Name = "button_themmonan";
            button_themmonan.Size = new Size(126, 45);
            button_themmonan.TabIndex = 7;
            button_themmonan.Text = "Thêm món ăn";
            button_themmonan.UseVisualStyleBackColor = true;
            button_themmonan.Click += button_themmonan_Click;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.ForeColor = Color.FromArgb(192, 0, 0);
            label_name.Location = new Point(12, 549);
            label_name.Name = "label_name";
            label_name.Size = new Size(118, 20);
            label_name.TabIndex = 8;
            label_name.Text = "Unauthenticated";
            // 
            // button_delete
            // 
            button_delete.Location = new Point(544, 66);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(126, 45);
            button_delete.TabIndex = 9;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 572);
            Controls.Add(button_delete);
            Controls.Add(label_name);
            Controls.Add(button_themmonan);
            Controls.Add(button_angigio);
            Controls.Add(comboBox_pagesize);
            Controls.Add(comboBox_page);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(tabControl);
            Name = "MainForm";
            Text = "Hôm nay ăn  gì";
            tabControl.ResumeLayout(false);
            tabPage_All.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_All).EndInit();
            tabPage_Me.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Me).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage_All;
        private TabPage tabPage_Me;
        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox_page;
        private ComboBox comboBox_pagesize;
        private Button button_angigio;
        private Button button_themmonan;
        private Label label_name;
        private DataGridView dataGridView_All;
        private DataGridView dataGridView_Me;
        private Button button_delete;
    }
}