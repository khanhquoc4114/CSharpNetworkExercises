namespace Lab03_Bai5
{
    partial class changeData
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
            dataGridView_monan = new DataGridView();
            dataGridView_nguoidung = new DataGridView();
            monAnBindingSource = new BindingSource(components);
            nguoiDungBindingSource = new BindingSource(components);
            button_save = new Button();
            button_back = new Button();
            button_delete_monan = new Button();
            button_delete_nguoidung = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_monan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_nguoidung).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monAnBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nguoiDungBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_monan
            // 
            dataGridView_monan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_monan.Location = new Point(43, 40);
            dataGridView_monan.Name = "dataGridView_monan";
            dataGridView_monan.RowHeadersWidth = 51;
            dataGridView_monan.Size = new Size(497, 331);
            dataGridView_monan.TabIndex = 0;
            // 
            // dataGridView_nguoidung
            // 
            dataGridView_nguoidung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_nguoidung.Location = new Point(615, 40);
            dataGridView_nguoidung.Name = "dataGridView_nguoidung";
            dataGridView_nguoidung.RowHeadersWidth = 51;
            dataGridView_nguoidung.Size = new Size(336, 331);
            dataGridView_nguoidung.TabIndex = 1;
            // 
            // monAnBindingSource
            // 
            monAnBindingSource.DataSource = typeof(Lab02.MonAn);
            // 
            // nguoiDungBindingSource
            // 
            nguoiDungBindingSource.DataSource = typeof(Lab02.NguoiDung);
            // 
            // button_save
            // 
            button_save.Location = new Point(43, 386);
            button_save.Name = "button_save";
            button_save.Size = new Size(101, 40);
            button_save.TabIndex = 2;
            button_save.Text = "Save all";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(167, 386);
            button_back.Name = "button_back";
            button_back.Size = new Size(110, 40);
            button_back.TabIndex = 3;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_delete_monan
            // 
            button_delete_monan.Location = new Point(615, 386);
            button_delete_monan.Name = "button_delete_monan";
            button_delete_monan.Size = new Size(148, 52);
            button_delete_monan.TabIndex = 4;
            button_delete_monan.Text = "Delete_selectedrow_monan";
            button_delete_monan.UseVisualStyleBackColor = true;
            button_delete_monan.Click += button_delete_monan_Click;
            // 
            // button_delete_nguoidung
            // 
            button_delete_nguoidung.Location = new Point(800, 386);
            button_delete_nguoidung.Name = "button_delete_nguoidung";
            button_delete_nguoidung.Size = new Size(151, 52);
            button_delete_nguoidung.TabIndex = 5;
            button_delete_nguoidung.Text = "Delete_selectedrow_nguoidung";
            button_delete_nguoidung.UseVisualStyleBackColor = true;
            button_delete_nguoidung.Click += button_delete_nguoidung_Click;
            // 
            // changeData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 450);
            Controls.Add(button_delete_nguoidung);
            Controls.Add(button_delete_monan);
            Controls.Add(button_back);
            Controls.Add(button_save);
            Controls.Add(dataGridView_nguoidung);
            Controls.Add(dataGridView_monan);
            Name = "changeData";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView_monan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_nguoidung).EndInit();
            ((System.ComponentModel.ISupportInitialize)monAnBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nguoiDungBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_monan;
        private BindingSource monAnBindingSource;
        private DataGridView dataGridView_nguoidung;
        private BindingSource nguoiDungBindingSource;
        private Button button_save;
        private Button button_back;
        private Button button_delete_nguoidung;
        private Button button_delete_monan;
    }
}