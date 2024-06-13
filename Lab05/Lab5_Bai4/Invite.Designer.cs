namespace Lab5_Bai4
{
    partial class Invite
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
            textBox_email = new TextBox();
            label1 = new Label();
            button_add = new Button();
            button_review = new Button();
            button_send = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(77, 26);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(279, 27);
            textBox_email.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 33);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // button_add
            // 
            button_add.Location = new Point(362, 24);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 2;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_review
            // 
            button_review.Location = new Point(262, 217);
            button_review.Name = "button_review";
            button_review.Size = new Size(94, 29);
            button_review.TabIndex = 3;
            button_review.Text = "Review";
            button_review.UseVisualStyleBackColor = true;
            button_review.Click += button_review_Click;
            // 
            // button_send
            // 
            button_send.Location = new Point(362, 217);
            button_send.Name = "button_send";
            button_send.Size = new Size(94, 29);
            button_send.TabIndex = 4;
            button_send.Text = "Send";
            button_send.UseVisualStyleBackColor = true;
            button_send.Click += button_send_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(25, 59);
            listView1.Name = "listView1";
            listView1.Size = new Size(431, 152);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Tile;
            // 
            // Invite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 265);
            Controls.Add(listView1);
            Controls.Add(button_send);
            Controls.Add(button_review);
            Controls.Add(button_add);
            Controls.Add(label1);
            Controls.Add(textBox_email);
            Name = "Invite";
            Text = "Invite";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_email;
        private Label label1;
        private Button button_add;
        private Button button_review;
        private Button button_send;
        private ListView listView1;
    }
}