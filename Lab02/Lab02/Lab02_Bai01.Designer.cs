namespace Lab02
{
    partial class Bai1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai1));
            button_save = new Button();
            button_Read = new Button();
            richTextBox_kq = new RichTextBox();
            button_clear = new Button();
            label_path = new Label();
            textBox_path = new TextBox();
            SuspendLayout();
            // 
            // button_save
            // 
            button_save.Location = new Point(57, 49);
            button_save.Name = "button_save";
            button_save.Size = new Size(78, 67);
            button_save.TabIndex = 0;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_Read
            // 
            button_Read.Location = new Point(57, 122);
            button_Read.Name = "button_Read";
            button_Read.Size = new Size(78, 67);
            button_Read.TabIndex = 1;
            button_Read.Text = "Read";
            button_Read.UseVisualStyleBackColor = true;
            button_Read.Click += button_read_Click;
            // 
            // richTextBox_kq
            // 
            richTextBox_kq.Font = new Font("Segoe UI", 13F);
            richTextBox_kq.Location = new Point(166, 49);
            richTextBox_kq.Name = "richTextBox_kq";
            richTextBox_kq.Size = new Size(638, 341);
            richTextBox_kq.TabIndex = 2;
            richTextBox_kq.Text = "";
            // 
            // button_clear
            // 
            button_clear.Location = new Point(57, 195);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(78, 67);
            button_clear.TabIndex = 3;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += buntton_clear_Click;
            // 
            // label_path
            // 
            label_path.AutoSize = true;
            label_path.Location = new Point(166, 9);
            label_path.Name = "label_path";
            label_path.Size = new Size(37, 20);
            label_path.TabIndex = 4;
            label_path.Text = "Path";
            // 
            // textBox_path
            // 
            textBox_path.Location = new Point(209, 9);
            textBox_path.Name = "textBox_path";
            textBox_path.Size = new Size(391, 27);
            textBox_path.TabIndex = 5;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(831, 415);
            Controls.Add(textBox_path);
            Controls.Add(label_path);
            Controls.Add(button_clear);
            Controls.Add(richTextBox_kq);
            Controls.Add(button_Read);
            Controls.Add(button_save);
            Name = "Bai1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_save;
        private Button button_Read;
        private RichTextBox richTextBox_kq;
        private Button button_clear;
        private Label label_path;
        private TextBox textBox_path;
    }
}
