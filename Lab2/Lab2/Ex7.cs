using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Ex7 : Form
    {
        public Ex7()
        {
            InitializeComponent();
            InitialsizeTreeView();
        }

        private void InitialsizeTreeView()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                TreeNode drNode = new TreeNode(drive.Name);
                drNode.Tag = drive.RootDirectory;
                treeView.Nodes.Add(drNode);
                LoadDirectories(drive.RootDirectory, drNode);
            }
        }

        private void LoadDirectories(DirectoryInfo dr, TreeNode parentNode)
        {
            try
            {
                foreach (DirectoryInfo dir in dr.GetDirectories())
                {
                    TreeNode node = new TreeNode(dir.Name);
                    node.Tag = dir;
                    parentNode.Nodes.Add(node);
                    node.Nodes.Add("Expand");
                }
            }
            catch (UnauthorizedAccessException)
            {

            }
        }

        private void loadFiles(TreeNode drNode)
        {
            DirectoryInfo dr = (DirectoryInfo)drNode.Tag;
            try
            {
                foreach (FileInfo file in dr.GetFiles())
                {
                    TreeNode node = new TreeNode(file.Name);
                    node.Tag = file;
                    drNode.Nodes.Add(node);
                }
            }
            catch (UnauthorizedAccessException) { }
        }



        private bool IsImgFile(FileInfo file)
        {
            string[] imageExtensions = { ".jpg", ".png" };
            string extension = file.Extension.ToLower();
            return Array.Exists(imageExtensions, ext => ext == extension);
        }

        private void showImg(string imgPath)
        {
            pBox_Content.Image = Image.FromFile(imgPath);
            pBox_Content.SizeMode = PictureBoxSizeMode.Zoom;
            pBox_Content.Visible = true;
            rTB_TextContent.Visible = false;
        }

        private void showTextContent(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                rTB_TextContent.Text = content;
            }
            catch (Exception ex)
            {
                rTB_TextContent.Text = "Error: " + ex.Message;
            }
            pBox_Content.Visible = false;
            rTB_TextContent.Visible = true;

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Expand")
            {
                TreeNode parentNode = e.Node.Parent;
                if (parentNode != null)
                {
                    parentNode.Nodes.Clear();
                    loadFiles(parentNode);
                }
            }
        }





        private void treeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is DirectoryInfo)
            {
                DirectoryInfo dr = (DirectoryInfo)e.Node.Tag;
                e.Node.Nodes.Clear();
                LoadDirectories(dr, e.Node);
                e.Node.Nodes.Add("Expand");
            }

            if (e.Node.Tag is FileInfo)
            {
                FileInfo selectedFile = (FileInfo)e.Node.Tag;
                if (IsImgFile(selectedFile))
                {
                    showImg(selectedFile.FullName);
                }
                else
                {
                    showTextContent(selectedFile.FullName);
                }
            }
        }

        private void Ex7_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }
    }
}
