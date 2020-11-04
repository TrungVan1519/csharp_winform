using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1_TreeView
{
    public partial class frmBasic : Form
    {
        public frmBasic()
        {
            InitializeComponent();
        }

        private void frmBasic_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            Data();
            this.ContextMenuStrip = contextMenuStrip;

            DialogResult result = MessageBox.Show("Do you want to expand all TreeView?", "Question", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                tvDisplay.ExpandAll();
            }
        }

        private void Data()
        {
            TreeNode root1 = new TreeNode();
            root1.Text = "1";
            tvDisplay.Nodes.Add(root1);
            for (int i = 1; i <= 3; i++)
            {
                TreeNode item = new TreeNode(i.ToString());
                tvDisplay.Nodes[0].Nodes.Add(item);
            }

            TreeNode root2 = new TreeNode("2");
            tvDisplay.Nodes.Add(root2);
            for (int i = 1; i < 3; i++)
            {
                TreeNode item = new TreeNode(i.ToString());
                tvDisplay.Nodes[1].Nodes.Add(item);
            }
        }

        // Giu nguyen Focus vao cac TreeNode khi su dung ContextMenuStrip ngoai TreeNode dau tien
        private void tvDisplay_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvDisplay.SelectedNode = e.Node;
        }

        private void tvDisplay_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvDisplay.SelectedNode.Level == 0)
            {
                tvDisplay.SelectedNode.ForeColor = Color.Red;
            }
            else if (tvDisplay.SelectedNode.Level == 1)
            {
                tvDisplay.SelectedNode.ForeColor = Color.Green;
            }
        }

        private void contextAdd_Click(object sender, EventArgs e)
        {
            if (tvDisplay.SelectedNode != null)
            {
                TreeNode addNode = new TreeNode("New Node");
                tvDisplay.SelectedNode.Nodes.Add(addNode);
            }
        }

        private void contextUpdate_Click(object sender, EventArgs e)
        {
            if (tvDisplay.SelectedNode != null)
            {
                TreeNode upNode = new TreeNode("Update Node");
                tvDisplay.SelectedNode.Text = upNode.Text;

                /// ????????????????????????????????????????????????
                //tvDisplay.SelectedNode.Tag = upNode;
                //tvDisplay.SelectedNode = tvDisplay.SelectedNode.Tag as TreeNode;
            }
        }

        private void contextDel_Click(object sender, EventArgs e)
        {
            if (tvDisplay.SelectedNode != null)
            {
                // Cach 1:
                tvDisplay.SelectedNode.Remove();
                //// Cach 2: 
                //tvDisplay.SelectedNode.Nodes.Remove(tvDisplay.SelectedNode);
                //// Cach 3:
                //tvDisplay.Nodes.Remove(tvDisplay.SelectedNode);
            }
        }

        private void contextExpnadEach_Click(object sender, EventArgs e)
        {
            if (tvDisplay.SelectedNode != null)
            {
                tvDisplay.SelectedNode.ExpandAll();
            }
        }

        private void contextExpandAll_Click(object sender, EventArgs e)
        {
            tvDisplay.ExpandAll();
        }

        private void contextCollapseEach_Click(object sender, EventArgs e)
        {
            if (tvDisplay.SelectedNode != null)
            {
                tvDisplay.SelectedNode.Collapse();
            }
        }

        private void contextCollapseAll_Click(object sender, EventArgs e)
        {
            tvDisplay.CollapseAll();
        }
    }
}
