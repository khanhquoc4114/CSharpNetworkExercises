﻿namespace Lab3_Bai6
{
    partial class Main
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
            this.btnClient = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(218, 12);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(200, 100);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Open Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(12, 12);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(200, 100);
            this.btnServer.TabIndex = 0;
            this.btnServer.Text = "Open Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 125);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.btnClient);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnServer;
    }
}