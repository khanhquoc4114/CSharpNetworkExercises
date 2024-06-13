namespace Lab02
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                textBox_path.Text = path;
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write(richTextBox_kq.Text.ToUpper());

                    }
                }
            }
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                textBox_path.Text = path;
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        richTextBox_kq.Text = sr.ReadToEnd();
                    }
                }
            }
        }

        private void buntton_clear_Click(object sender, EventArgs e)
        {
            richTextBox_kq.Text = "";
            textBox_path.Text = "";
        }

    }
}
