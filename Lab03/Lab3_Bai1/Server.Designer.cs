namespace Lab3_Bai1
{
    partial class Server
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
            label1 = new Label();
            label2 = new Label();
            textBox_port = new TextBox();
            listView1 = new ListView();
            button_Listen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 0;
            label1.Text = "Received messages";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 19);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "Port";
            // 
            // textBox_port
            // 
            textBox_port.Location = new Point(377, 58);
            textBox_port.Name = "textBox_port";
            textBox_port.Size = new Size(103, 27);
            textBox_port.TabIndex = 2;
            textBox_port.Text = "8080";
            // 
            // listView1
            // 
            listView1.Location = new Point(30, 58);
            listView1.Name = "listView1";
            listView1.Size = new Size(317, 346);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // button_Listen
            // 
            button_Listen.Location = new Point(377, 114);
            button_Listen.Name = "button_Listen";
            button_Listen.Size = new Size(88, 67);
            button_Listen.TabIndex = 4;
            button_Listen.Text = "Listen";
            button_Listen.UseVisualStyleBackColor = true;
            button_Listen.Click += button_Listen_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 416);
            Controls.Add(button_Listen);
            Controls.Add(listView1);
            Controls.Add(textBox_port);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Server";
            Text = "Bai1_UDPserver";
            FormClosing += Server_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_port;
        private ListView listView1;
        private Button button_Listen;
    }
}