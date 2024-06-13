namespace Lab01
{
    partial class Bai6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai6));
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            textBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(253, 90);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(331, 187);
            button1.Name = "button1";
            button1.Size = new Size(94, 58);
            button1.TabIndex = 1;
            button1.Text = "Úm ba la";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(290, 305);
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(166, 27);
            textBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 90);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 3;
            label1.Text = "Chọn ngày";
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Name = "Bai6";
            Text = "Bai6";
            Load += Bai6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button1;
        private TextBox textBox;
        private Label label1;
    }
}