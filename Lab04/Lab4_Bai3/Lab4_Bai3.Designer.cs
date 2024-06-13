namespace Lab4_Bai3
{
    partial class Lab4_Bai3
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
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDownRes = new System.Windows.Forms.Button();
            this.btnDownFile = new System.Windows.Forms.Button();
            this.addressBar = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webView.Location = new System.Drawing.Point(0, 70);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(796, 539);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(12, 41);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDownRes
            // 
            this.btnDownRes.Location = new System.Drawing.Point(676, 41);
            this.btnDownRes.Name = "btnDownRes";
            this.btnDownRes.Size = new System.Drawing.Size(112, 23);
            this.btnDownRes.TabIndex = 3;
            this.btnDownRes.Text = "Down Resources";
            this.btnDownRes.UseVisualStyleBackColor = true;
            this.btnDownRes.Click += new System.EventHandler(this.btnDownRes_Click);
            // 
            // btnDownFile
            // 
            this.btnDownFile.Location = new System.Drawing.Point(713, 12);
            this.btnDownFile.Name = "btnDownFile";
            this.btnDownFile.Size = new System.Drawing.Size(75, 23);
            this.btnDownFile.TabIndex = 4;
            this.btnDownFile.Text = "Down Files";
            this.btnDownFile.UseVisualStyleBackColor = true;
            this.btnDownFile.Click += new System.EventHandler(this.btnDownFile_Click);
            // 
            // addressBar
            // 
            this.addressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBar.Location = new System.Drawing.Point(93, 12);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(614, 20);
            this.addressBar.TabIndex = 5;
            this.addressBar.Text = "uit.edu.vn";
            this.addressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyDown);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(93, 41);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(496, 23);
            this.progressBar.TabIndex = 6;
            this.progressBar.Value = 50;
            this.progressBar.Visible = false;
            // 
            // Lab4_Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 609);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.addressBar);
            this.Controls.Add(this.btnDownFile);
            this.Controls.Add(this.btnDownRes);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.webView);
            this.Name = "Lab4_Bai3";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDownRes;
        private System.Windows.Forms.Button btnDownFile;
        private System.Windows.Forms.TextBox addressBar;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

