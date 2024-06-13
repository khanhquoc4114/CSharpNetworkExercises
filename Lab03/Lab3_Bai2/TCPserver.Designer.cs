namespace Lab03_Bai2
{
    partial class TCPserver
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
            listView_message = new ListView();
            button_listen = new Button();
            SuspendLayout();
            // 
            // listView_message
            // 
            listView_message.Location = new Point(61, 103);
            listView_message.Name = "listView_message";
            listView_message.Size = new Size(532, 308);
            listView_message.TabIndex = 0;
            listView_message.UseCompatibleStateImageBehavior = false;
            listView_message.View = View.Tile;
            // 
            // button_listen
            // 
            button_listen.Location = new Point(499, 39);
            button_listen.Name = "button_listen";
            button_listen.Size = new Size(94, 35);
            button_listen.TabIndex = 1;
            button_listen.Text = "Listen";
            button_listen.UseVisualStyleBackColor = true;
            button_listen.Click += button_listen_Click;
            // 
            // TCPserver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 450);
            Controls.Add(button_listen);
            Controls.Add(listView_message);
            Name = "TCPserver";
            Text = "Form1";
            FormClosed += TCPserver_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView_message;
        private Button button_listen;
    }
}
