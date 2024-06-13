using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();

            treeView1.BeforeExpand += new TreeViewCancelEventHandler(treeView1_BeforeExpand);
            treeView1.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(treeView1_NodeMouseDoubleClick);

            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrives)
            {
                if (drive.IsReady)
                {
                    TreeNode root = new TreeNode(drive.Name);
                    root.Nodes.Add(null, "Loading..."); // Add a dummy node
                    treeView1.Nodes.Add(root);
                }
            }
        }

        void directoryexpand(TreeNode root)
        {
            try
            {
                // Get directories
                var dirInfo = new DirectoryInfo(root.FullPath);
                foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                {
                    // Add directory node
                    var newNode = new TreeNode(dir.Name);
                    newNode.Nodes.Add(null, "Loading..."); // Add a dummy node
                    root.Nodes.Add(newNode);
                }
                foreach (FileInfo file in dirInfo.GetFiles())
                {
                    // Add file node
                    root.Nodes.Add(new TreeNode(file.Name));
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Handle lack of access rights
            }
            catch (Exception ex)
            {
                // Handle other exceptions
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            // Check if the node has been loaded
            if (e.Node.Nodes[0].Text == "Loading...")
            {
                // Clear the dummy node
                e.Node.Nodes.Clear();

                // Load the children of the node
                directoryexpand(e.Node);
            }
        }
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = e.Node.FullPath;
            if (File.Exists(path))
            {
                string extension = Path.GetExtension(path).ToLower();
                if (extension == ".jpg" || extension == ".png")
                {
                    // Set the PictureBox to stretch the image to fit
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    // Display the image in a PictureBox
                    pictureBox1.Image = Image.FromFile(path);
                    pictureBox1.BringToFront();
                }
                else if (extension == ".txt")
                {
                    // Display the text in a RichTextBox
                    richTextBox1.LoadFile(path, RichTextBoxStreamType.PlainText);
                    richTextBox1.BringToFront();
                }
            }
        }
    }
}