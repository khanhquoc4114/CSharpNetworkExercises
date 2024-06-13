namespace Lab02
{
    partial class Bai2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai2));
            label_filename = new Label();
            label_size = new Label();
            label_linecount = new Label();
            label_url = new Label();
            label_charactercount = new Label();
            label_wordcount = new Label();
            textBox_filename = new TextBox();
            textBox_size = new TextBox();
            textBox_url = new TextBox();
            textBox_linecount = new TextBox();
            textBox_wordcount = new TextBox();
            textBox_charactercount = new TextBox();
            richTextBox_kq = new RichTextBox();
            button_read = new Button();
            button_clear = new Button();
            SuspendLayout();
            // 
            // label_filename
            // 
            label_filename.AutoSize = true;
            label_filename.Location = new Point(473, 44);
            label_filename.Name = "label_filename";
            label_filename.Size = new Size(76, 20);
            label_filename.TabIndex = 0;
            label_filename.Text = "File Name";
            // 
            // label_size
            // 
            label_size.AutoSize = true;
            label_size.Location = new Point(473, 99);
            label_size.Name = "label_size";
            label_size.Size = new Size(36, 20);
            label_size.TabIndex = 0;
            label_size.Text = "Size";
            // 
            // label_linecount
            // 
            label_linecount.AutoSize = true;
            label_linecount.Location = new Point(473, 217);
            label_linecount.Name = "label_linecount";
            label_linecount.Size = new Size(79, 20);
            label_linecount.TabIndex = 1;
            label_linecount.Text = "Line Count";
            // 
            // label_url
            // 
            label_url.AutoSize = true;
            label_url.Location = new Point(473, 162);
            label_url.Name = "label_url";
            label_url.Size = new Size(35, 20);
            label_url.TabIndex = 2;
            label_url.Text = "URL";
            // 
            // label_charactercount
            // 
            label_charactercount.AutoSize = true;
            label_charactercount.Location = new Point(473, 329);
            label_charactercount.Name = "label_charactercount";
            label_charactercount.Size = new Size(115, 20);
            label_charactercount.TabIndex = 3;
            label_charactercount.Text = "Character Count";
            // 
            // label_wordcount
            // 
            label_wordcount.AutoSize = true;
            label_wordcount.Location = new Point(473, 269);
            label_wordcount.Name = "label_wordcount";
            label_wordcount.Size = new Size(88, 20);
            label_wordcount.TabIndex = 4;
            label_wordcount.Text = "Word Count";
            // 
            // textBox_filename
            // 
            textBox_filename.Location = new Point(594, 37);
            textBox_filename.Name = "textBox_filename";
            textBox_filename.Size = new Size(173, 27);
            textBox_filename.TabIndex = 5;
            // 
            // textBox_size
            // 
            textBox_size.Location = new Point(594, 96);
            textBox_size.Name = "textBox_size";
            textBox_size.Size = new Size(173, 27);
            textBox_size.TabIndex = 6;
            // 
            // textBox_url
            // 
            textBox_url.Location = new Point(594, 159);
            textBox_url.Name = "textBox_url";
            textBox_url.Size = new Size(173, 27);
            textBox_url.TabIndex = 7;
            // 
            // textBox_linecount
            // 
            textBox_linecount.Location = new Point(594, 217);
            textBox_linecount.Name = "textBox_linecount";
            textBox_linecount.Size = new Size(173, 27);
            textBox_linecount.TabIndex = 8;
            // 
            // textBox_wordcount
            // 
            textBox_wordcount.Location = new Point(594, 266);
            textBox_wordcount.Name = "textBox_wordcount";
            textBox_wordcount.Size = new Size(173, 27);
            textBox_wordcount.TabIndex = 9;
            // 
            // textBox_charactercount
            // 
            textBox_charactercount.Location = new Point(594, 326);
            textBox_charactercount.Name = "textBox_charactercount";
            textBox_charactercount.Size = new Size(173, 27);
            textBox_charactercount.TabIndex = 10;
            // 
            // richTextBox_kq
            // 
            richTextBox_kq.Font = new Font("Segoe UI", 13F);
            richTextBox_kq.Location = new Point(45, 37);
            richTextBox_kq.Name = "richTextBox_kq";
            richTextBox_kq.Size = new Size(380, 377);
            richTextBox_kq.TabIndex = 11;
            richTextBox_kq.Text = "";
            // 
            // button_read
            // 
            button_read.Location = new Point(594, 368);
            button_read.Name = "button_read";
            button_read.Size = new Size(70, 64);
            button_read.TabIndex = 13;
            button_read.Text = "Read";
            button_read.UseVisualStyleBackColor = true;
            button_read.Click += button_read_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(697, 368);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(70, 64);
            button_clear.TabIndex = 14;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button_clear);
            Controls.Add(button_read);
            Controls.Add(richTextBox_kq);
            Controls.Add(textBox_charactercount);
            Controls.Add(textBox_wordcount);
            Controls.Add(textBox_linecount);
            Controls.Add(textBox_url);
            Controls.Add(textBox_size);
            Controls.Add(textBox_filename);
            Controls.Add(label_charactercount);
            Controls.Add(label_wordcount);
            Controls.Add(label_linecount);
            Controls.Add(label_url);
            Controls.Add(label_size);
            Controls.Add(label_filename);
            Name = "Bai2";
            Text = "Bai2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_filename;
        private Label label_size;
        private Label label_linecount;
        private Label label_url;
        private Label label_charactercount;
        private Label label_wordcount;
        private TextBox textBox_filename;
        private TextBox textBox_size;
        private TextBox textBox_url;
        private TextBox textBox_linecount;
        private TextBox textBox_wordcount;
        private TextBox textBox_charactercount;
        private RichTextBox richTextBox_kq;
        private Button button_read;
        private Button button_clear;
    }
}