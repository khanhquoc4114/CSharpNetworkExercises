using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Bai1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button_server_Click(object sender, EventArgs e)
        {
            Server serverForm = new Server();
            serverForm.Show();
        }

        private void button_client_Click(object sender, EventArgs e)
        {
            Client clientForm = new Client();
            clientForm.Show();
        }
    }
}
