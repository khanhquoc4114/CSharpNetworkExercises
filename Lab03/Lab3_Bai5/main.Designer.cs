namespace Lab03_Bai5
{
    partial class main
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
            button = new Button();
            button_server = new Button();
            button_changeData = new Button();
            SuspendLayout();
            // 
            // button
            // 
            button.Anchor = AnchorStyles.None;
            button.Location = new Point(12, 110);
            button.Name = "button";
            button.Size = new Size(207, 62);
            button.TabIndex = 0;
            button.Text = "Login form";
            button.UseVisualStyleBackColor = true;
            button.Click += button1_Click;
            // 
            // button_server
            // 
            button_server.Anchor = AnchorStyles.None;
            button_server.Location = new Point(12, 28);
            button_server.Name = "button_server";
            button_server.Size = new Size(207, 62);
            button_server.TabIndex = 1;
            button_server.Text = "Server";
            button_server.UseVisualStyleBackColor = true;
            button_server.Click += button_server_Click;
            // 
            // button_changeData
            // 
            button_changeData.Anchor = AnchorStyles.None;
            button_changeData.Location = new Point(12, 188);
            button_changeData.Name = "button_changeData";
            button_changeData.Size = new Size(207, 62);
            button_changeData.TabIndex = 2;
            button_changeData.Text = "Change Data";
            button_changeData.UseVisualStyleBackColor = true;
            button_changeData.Click += button_changeData_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 262);
            Controls.Add(button_changeData);
            Controls.Add(button_server);
            Controls.Add(button);
            Name = "main";
            Text = "main";
            ResumeLayout(false);
        }

        #endregion

        private Button button;
        private Button button_server;
        private Button button_changeData;
    }
}