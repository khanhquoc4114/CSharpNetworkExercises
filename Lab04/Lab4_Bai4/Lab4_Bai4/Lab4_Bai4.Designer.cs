namespace Lab4_Bai4
{
    partial class Lab4_Bai4
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanelMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMovies
            // 
            this.flowLayoutPanelMovies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelMovies.Location = new System.Drawing.Point(12, 57);
            this.flowLayoutPanelMovies.Name = "flowLayoutPanelMovies";
            this.flowLayoutPanelMovies.Size = new System.Drawing.Size(777, 661);
            this.flowLayoutPanelMovies.TabIndex = 1;
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.ForeColor = System.Drawing.Color.HotPink;
            this.progressBarLoading.Location = new System.Drawing.Point(12, 724);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(776, 23);
            this.progressBarLoading.TabIndex = 2;
            this.progressBarLoading.Value = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "PHIM ĐANG CHIẾU";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 759);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarLoading);
            this.Controls.Add(this.flowLayoutPanelMovies);
            this.Name = "Form1";
            this.Text = "Cinema Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMovies;
        private System.Windows.Forms.ProgressBar progressBarLoading;
        private System.Windows.Forms.Label label1;
    }

    #endregion
}

