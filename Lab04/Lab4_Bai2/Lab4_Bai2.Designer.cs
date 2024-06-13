namespace Lab4_Bai2
{
    partial class Lab4_Bai2
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
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtDownload = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbContent
            // 
            this.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbContent.Location = new System.Drawing.Point(0, 60);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.ReadOnly = true;
            this.rtbContent.Size = new System.Drawing.Size(800, 390);
            this.rtbContent.TabIndex = 5;
            this.rtbContent.Text = "";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(713, 5);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 4;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtURL.Location = new System.Drawing.Point(12, 8);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(695, 20);
            this.txtURL.TabIndex = 3;
            this.txtURL.Text = "uit.edu.vn";
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyDown);
            // 
            // txtDownload
            // 
            this.txtDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDownload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDownload.Location = new System.Drawing.Point(12, 34);
            this.txtDownload.Name = "txtDownload";
            this.txtDownload.Size = new System.Drawing.Size(695, 20);
            this.txtDownload.TabIndex = 3;
            this.txtDownload.Text = "E:\\uit.html";
            this.txtDownload.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDownload_KeyDown);
            // 
            // btnDownload
            // 
            this.btnDownload.Enabled = false;
            this.btnDownload.Location = new System.Drawing.Point(713, 34);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // Lab4_Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtDownload);
            this.Controls.Add(this.txtURL);
            this.Name = "Lab4_Bai2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtDownload;
        private System.Windows.Forms.Button btnDownload;
    }
}

