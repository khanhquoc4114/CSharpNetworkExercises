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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai3));
            richTextBox1 = new RichTextBox();
            button_read = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 13F);
            richTextBox1.Location = new Point(0, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(559, 447);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button_read
            // 
            button_read.Location = new Point(625, 197);
            button_read.Name = "button_read";
            button_read.Size = new Size(94, 51);
            button_read.TabIndex = 1;
            button_read.Text = "Đọc file";
            button_read.UseVisualStyleBackColor = true;
            button_read.Click += button_read_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button_read);
            Controls.Add(richTextBox1);
            Name = "Bai3";
            Text = "Bài 3";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button_read;
    }
}