namespace Lab5_Bai5
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
            this.txtImap = new System.Windows.Forms.TextBox();
            this.txtSmtp = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.listViewEmails = new System.Windows.Forms.ListView();
            this.nPortSmtp = new System.Windows.Forms.NumericUpDown();
            this.nPortImap = new System.Windows.Forms.NumericUpDown();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.nPortSmtp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPortImap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtImap
            // 
            this.txtImap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImap.Location = new System.Drawing.Point(76, 27);
            this.txtImap.Margin = new System.Windows.Forms.Padding(4);
            this.txtImap.Name = "txtImap";
            this.txtImap.Size = new System.Drawing.Size(154, 27);
            this.txtImap.TabIndex = 0;
            this.txtImap.Text = "imap.gmail.com";
            // 
            // txtSmtp
            // 
            this.txtSmtp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSmtp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmtp.Location = new System.Drawing.Point(311, 27);
            this.txtSmtp.Margin = new System.Windows.Forms.Padding(4);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(190, 27);
            this.txtSmtp.TabIndex = 0;
            this.txtSmtp.Text = "smtp.gmail.com";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(247, 100);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 43);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // listViewEmails
            // 
            this.listViewEmails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewEmails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewEmails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewEmails.HideSelection = false;
            this.listViewEmails.Location = new System.Drawing.Point(0, 177);
            this.listViewEmails.Margin = new System.Windows.Forms.Padding(4);
            this.listViewEmails.Name = "listViewEmails";
            this.listViewEmails.Size = new System.Drawing.Size(904, 374);
            this.listViewEmails.TabIndex = 2;
            this.listViewEmails.UseCompatibleStateImageBehavior = false;
            // 
            // nPortSmtp
            // 
            this.nPortSmtp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nPortSmtp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPortSmtp.Location = new System.Drawing.Point(311, 64);
            this.nPortSmtp.Margin = new System.Windows.Forms.Padding(4);
            this.nPortSmtp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nPortSmtp.Name = "nPortSmtp";
            this.nPortSmtp.Size = new System.Drawing.Size(191, 27);
            this.nPortSmtp.TabIndex = 3;
            this.nPortSmtp.Value = new decimal(new int[] {
            465,
            0,
            0,
            0});
            // 
            // nPortImap
            // 
            this.nPortImap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nPortImap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPortImap.Location = new System.Drawing.Point(76, 64);
            this.nPortImap.Margin = new System.Windows.Forms.Padding(4);
            this.nPortImap.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nPortImap.Name = "nPortImap";
            this.nPortImap.Size = new System.Drawing.Size(155, 27);
            this.nPortImap.TabIndex = 3;
            this.nPortImap.Value = new decimal(new int[] {
            993,
            0,
            0,
            0});
            // 
            // btnSendMail
            // 
            this.btnSendMail.AutoSize = true;
            this.btnSendMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.Location = new System.Drawing.Point(15, 100);
            this.btnSendMail.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(109, 43);
            this.btnSendMail.TabIndex = 1;
            this.btnSendMail.Text = "Compose";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSendMail);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(356, 155);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(104, 27);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 27);
            this.txtEmail.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(104, 64);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(243, 27);
            this.txtPass.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(131, 100);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 43);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.progressBar);
            this.groupBox2.Controls.Add(this.txtImap);
            this.groupBox2.Controls.Add(this.txtSmtp);
            this.groupBox2.Controls.Add(this.nPortSmtp);
            this.groupBox2.Controls.Add(this.nPortImap);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(380, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(509, 155);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cài đặt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "SMTP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "IMAP";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(9, 113);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(492, 28);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 4;
            this.progressBar.Value = 50;
            this.progressBar.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewEmails);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Homemade Gmail";
            ((System.ComponentModel.ISupportInitialize)(this.nPortSmtp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPortImap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtImap;
        private System.Windows.Forms.TextBox txtSmtp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ListView listViewEmails;
        private System.Windows.Forms.NumericUpDown nPortSmtp;
        private System.Windows.Forms.NumericUpDown nPortImap;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

