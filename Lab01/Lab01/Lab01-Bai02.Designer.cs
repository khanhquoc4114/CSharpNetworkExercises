namespace Lab01
{
    partial class Bai2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai2));
            textBox_sothuhai = new TextBox();
            textBox_sothuba = new TextBox();
            label_sothuhai = new Label();
            label_Sothuba = new Label();
            button_tim = new Button();
            button_xoa = new Button();
            buton_thoat = new Button();
            label_solonnhat = new Label();
            label_sonhonhat = new Label();
            textBox_sonhonhat = new TextBox();
            textbox_solonnhat = new TextBox();
            label_sothunhat = new Label();
            textBox_sothunhat = new TextBox();
            SuspendLayout();
            // 
            // textBox_sothuhai
            // 
            textBox_sothuhai.Location = new Point(391, 79);
            textBox_sothuhai.Name = "textBox_sothuhai";
            textBox_sothuhai.Size = new Size(152, 27);
            textBox_sothuhai.TabIndex = 1;
            // 
            // textBox_sothuba
            // 
            textBox_sothuba.Location = new Point(659, 82);
            textBox_sothuba.Name = "textBox_sothuba";
            textBox_sothuba.Size = new Size(152, 27);
            textBox_sothuba.TabIndex = 2;
            // 
            // label_sothuhai
            // 
            label_sothuhai.AutoSize = true;
            label_sothuhai.Location = new Point(309, 82);
            label_sothuhai.Name = "label_sothuhai";
            label_sothuhai.Size = new Size(76, 20);
            label_sothuhai.TabIndex = 4;
            label_sothuhai.Text = "Số thứ hai";
            // 
            // label_Sothuba
            // 
            label_Sothuba.AutoSize = true;
            label_Sothuba.Location = new Point(580, 82);
            label_Sothuba.Name = "label_Sothuba";
            label_Sothuba.Size = new Size(73, 20);
            label_Sothuba.TabIndex = 5;
            label_Sothuba.Text = "Số thứ ba";
            // 
            // button_tim
            // 
            button_tim.Location = new Point(273, 283);
            button_tim.Name = "button_tim";
            button_tim.Size = new Size(68, 66);
            button_tim.TabIndex = 6;
            button_tim.Text = "Tìm";
            button_tim.UseVisualStyleBackColor = true;
            button_tim.Click += button_tim_Click;
            // 
            // button_xoa
            // 
            button_xoa.Location = new Point(412, 283);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(68, 66);
            button_xoa.TabIndex = 7;
            button_xoa.Text = "Xoá";
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // buton_thoat
            // 
            buton_thoat.Location = new Point(547, 286);
            buton_thoat.Name = "buton_thoat";
            buton_thoat.Size = new Size(68, 63);
            buton_thoat.TabIndex = 8;
            buton_thoat.Text = "Thoát";
            buton_thoat.UseVisualStyleBackColor = true;
            buton_thoat.Click += buton_thoat_Click;
            // 
            // label_solonnhat
            // 
            label_solonnhat.AutoSize = true;
            label_solonnhat.Location = new Point(156, 222);
            label_solonnhat.Name = "label_solonnhat";
            label_solonnhat.Size = new Size(84, 20);
            label_solonnhat.TabIndex = 9;
            label_solonnhat.Text = "Số lớn nhất";
            // 
            // label_sonhonhat
            // 
            label_sonhonhat.AutoSize = true;
            label_sonhonhat.Location = new Point(455, 222);
            label_sonhonhat.Name = "label_sonhonhat";
            label_sonhonhat.Size = new Size(88, 20);
            label_sonhonhat.TabIndex = 10;
            label_sonhonhat.Text = "Số nhỏ nhất";
            // 
            // textBox_sonhonhat
            // 
            textBox_sonhonhat.Location = new Point(549, 222);
            textBox_sonhonhat.Name = "textBox_sonhonhat";
            textBox_sonhonhat.Size = new Size(152, 27);
            textBox_sonhonhat.TabIndex = 12;
            // 
            // textbox_solonnhat
            // 
            textbox_solonnhat.Location = new Point(246, 219);
            textbox_solonnhat.Name = "textbox_solonnhat";
            textbox_solonnhat.Size = new Size(152, 27);
            textbox_solonnhat.TabIndex = 13;
            // 
            // label_sothunhat
            // 
            label_sothunhat.AutoSize = true;
            label_sothunhat.Location = new Point(40, 82);
            label_sothunhat.Name = "label_sothunhat";
            label_sothunhat.Size = new Size(85, 20);
            label_sothunhat.TabIndex = 14;
            label_sothunhat.Text = "Số thứ nhất";
            // 
            // textBox_sothunhat
            // 
            textBox_sothunhat.Location = new Point(131, 79);
            textBox_sothunhat.Name = "textBox_sothunhat";
            textBox_sothunhat.Size = new Size(152, 27);
            textBox_sothunhat.TabIndex = 15;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(894, 450);
            Controls.Add(textBox_sothunhat);
            Controls.Add(label_sothunhat);
            Controls.Add(textbox_solonnhat);
            Controls.Add(textBox_sonhonhat);
            Controls.Add(label_sonhonhat);
            Controls.Add(label_solonnhat);
            Controls.Add(buton_thoat);
            Controls.Add(button_xoa);
            Controls.Add(button_tim);
            Controls.Add(label_Sothuba);
            Controls.Add(label_sothuhai);
            Controls.Add(textBox_sothuba);
            Controls.Add(textBox_sothuhai);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_sothuhai;
        private TextBox textBox_sothuba;
        private Label label_sothuhai;
        private Label label_Sothuba;
        
        private Button button_tim;
        private Button button_xoa;
        private Button buton_thoat;
        private Label label_solonnhat;
        private Label label_sonhonhat;
        private TextBox textBox_sonhonhat;
        private TextBox textbox_solonnhat;
        private Label label_sothunhat;
        private TextBox textBox_sothunhat;
    }
}