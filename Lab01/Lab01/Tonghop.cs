namespace Lab01
{
    public partial class Tonghop : Form
    {
        public Tonghop()
        {
            InitializeComponent();
            foreach (Control control in splitContainer1.Panel2.Controls)
            {
                originalControls.Add(control);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }


        List<Control> originalControls = new List<Control>();
        private void Bai1_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các controls hiện tại
            splitContainer1.Panel2.Controls.Clear();

            // Hiển thị Bai1
            Bai1 bai1 = new Bai1();
            bai1.TopLevel = false;
            bai1.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(bai1);
            bai1.Dock = DockStyle.Fill;
            bai1.Show();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            Bai2 bai2 = new Bai2();
            bai2.TopLevel = false;
            bai2.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(bai2);
            bai2.Dock = DockStyle.Fill;
            bai2.Show();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            foreach (Control control in originalControls)
            {
                splitContainer1.Panel2.Controls.Add(control);
            }
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

         
            Bai3 bai3 = new Bai3();
            bai3.TopLevel = false;
            bai3.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(bai3);
            bai3.Dock = DockStyle.Fill;
            bai3.Show();
        }

        private void Bai3_1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            Bai3_1 bai3_1 = new Bai3_1();
            bai3_1.TopLevel = false;
            bai3_1.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(bai3_1);
            bai3_1.Dock = DockStyle.Fill;
            bai3_1.Show();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            Bai4 bai4 = new Bai4();
            bai4.TopLevel = false;
            bai4.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(bai4);
            bai4.Dock = DockStyle.Fill;
            bai4.Show();
        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            Bai5 bai5 = new Bai5();
            bai5.TopLevel = false;
            bai5.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(bai5);
            bai5.Dock = DockStyle.Fill;
            bai5.Show();
        }

        private void Bai6_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            Bai6 bai6 = new Bai6();
            bai6.TopLevel = false;
            bai6.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(bai6);
            bai6.Dock = DockStyle.Fill;
            bai6.Show();
        }

        private void Bai7_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            Bai7 bai7 = new Bai7();
            bai7.TopLevel = false;
            bai7.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(bai7);
            bai7.Dock = DockStyle.Fill;
            bai7.Show();
        }

        private void Bai8_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            Bai8 bai8 = new Bai8();
            bai8.TopLevel = false;
            bai8.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(bai8);
            bai8.Dock = DockStyle.Fill;
            bai8.Show();
        }
    }
}
