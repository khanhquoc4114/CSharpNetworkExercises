using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetStartedWinForms;
using Lab02;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab03_Bai5
{
    public partial class changeData : Form
    {
        private MonAnsContext dbContext;
        private TcpClient client;
        private Thread listenThread;
        private CancellationTokenSource cancellationTokenSource;

        public changeData(MonAnsContext dbContext, TcpClient tcpclient)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.client = tcpclient;
        }
        protected override void OnLoad(EventArgs e)
        {
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            base.OnLoad(e);
            this.dbContext.monan.Load(); // Load data from 'monan' table
            this.dbContext.nguoidung.Load();

            cancellationTokenSource = new CancellationTokenSource();

            // Bind the DataGridView to the list of dishes and users
            dataGridView_monan.DataSource = dbContext.monan.Local.ToBindingList();
            dataGridView_nguoidung.DataSource = dbContext.nguoidung.Local.ToBindingList();
            ListenForServerMessages();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            try
            {
                this.dbContext?.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}");
            }
            if (cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
            }
        }


        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_monan.EndEdit();
                dataGridView_nguoidung.EndEdit();
                this.dbContext?.SaveChanges();
                dataGridView_monan.DataSource = dbContext.monan.Local.ToBindingList();
                dataGridView_nguoidung.DataSource = dbContext.nguoidung.Local.ToBindingList();

                // Create a simple event to notify the server of the database change
                var data = new { Event = "DatabaseChanged" };

                // Convert the event to JSON
                string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);

                // Send the event to the server
                SendDataToServer(jsonData);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error saving changes");
            }
        }

        private void SendDataToServer(string data)
        {
            if (client != null && client.Connected)
            {
                NetworkStream stream = client.GetStream();
                byte[] bytesToSend = Encoding.UTF8.GetBytes(data);
                stream.Write(bytesToSend, 0, bytesToSend.Length);
            }
            else
            {
                MessageBox.Show("Not connected to the server.");
            }
        }
        private MonAnsContext context;
        private async Task ListenForServerMessages()
        {
            while (!cancellationTokenSource.Token.IsCancellationRequested)
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead;
                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    // If the message is a reload data event
                    if (message.Contains("ReloadData"))
                    {
                        // Check if the form's handle has been created
                        if (this.IsHandleCreated)
                        {
                            // Use Invoke to update the UI on the main thread
                            this.Invoke((MethodInvoker)delegate
                            {
                                // Reload the data
                                foreach (var entity in dbContext.monan.Local.ToList())
                                {
                                    dbContext.Entry(entity).Reload();
                                }
                                foreach (var entity in dbContext.nguoidung.Local.ToList())
                                {
                                    dbContext.Entry(entity).Reload();
                                }

                                // Update the DataGridViews
                                dataGridView_monan.DataSource = dbContext.monan.Local.ToBindingList();
                                dataGridView_nguoidung.DataSource = dbContext.nguoidung.Local.ToBindingList();
                            });
                        }
                    }

                    // Check if cancellation was requested
                    if (cancellationTokenSource.Token.IsCancellationRequested)
                    {
                        break;
                    }
                }
            }
        }



        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_delete_nguoidung_Click(object sender, EventArgs e)
        {
            if (dataGridView_nguoidung.CurrentCell == null)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            // Get the index of the selected row
            int rowIndex = dataGridView_nguoidung.CurrentCell.RowIndex;

            // Get the ID of the user from the selected row
            var userId = (int)dataGridView_nguoidung.Rows[rowIndex].Cells["IDNCC"].Value;

            // Find the user in the database
            var user = dbContext.nguoidung.Find(userId);

            // Remove the user from the database
            dbContext.nguoidung.Remove(user);

            // Save changes to the database
            //dbContext.SaveChanges();

            // Refresh the DataGridView
            dataGridView_nguoidung.DataSource = dbContext.nguoidung.Local.ToBindingList();
        }

        private void button_delete_monan_Click(object sender, EventArgs e)
        {
            if (dataGridView_monan.CurrentCell == null)
            {
                MessageBox.Show("Please select a dish to delete.");
                return;
            }

            // Get the index of the selected row
            int rowIndex = dataGridView_monan.CurrentCell.RowIndex;

            // Get the ID of the dish from the selected row
            var dishId = (int)dataGridView_monan.Rows[rowIndex].Cells["IDMA"].Value;

            // Find the dish in the database
            var dish = dbContext.monan.Find(dishId);

            // Remove the dish from the database
            dbContext.monan.Remove(dish);

            // Save changes to the database
            //dbContext.SaveChanges();

            // Refresh the DataGridView
            dataGridView_monan.DataSource = dbContext.monan.Local.ToBindingList();
        }

    }
}