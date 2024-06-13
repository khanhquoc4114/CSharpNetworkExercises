namespace Lab5_Bai5
{
    partial class Detail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.btnReply = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "From:";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.Location = new System.Drawing.Point(115, 11);
            this.lbFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(63, 23);
            this.lbFrom.TabIndex = 0;
            this.lbFrom.Text = "lbFrom";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.Location = new System.Drawing.Point(115, 46);
            this.lbTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(41, 23);
            this.lbTo.TabIndex = 0;
            this.lbTo.Text = "lbTo";
            // 
            // btnReply
            // 
            this.btnReply.AutoSize = true;
            this.btnReply.BackColor = System.Drawing.Color.Transparent;
            this.btnReply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReply.FlatAppearance.BorderSize = 0;
            this.btnReply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReply.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReply.Location = new System.Drawing.Point(642, 5);
            this.btnReply.Margin = new System.Windows.Forms.Padding(4);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(81, 64);
            this.btnReply.TabIndex = 1;
            this.btnReply.Text = "🔙";
            this.btnReply.UseVisualStyleBackColor = false;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(0, 72);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(732, 371);
            this.webBrowser.TabIndex = 2;
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 443);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Detail";
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.Detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}