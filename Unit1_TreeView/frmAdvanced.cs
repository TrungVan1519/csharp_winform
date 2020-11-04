using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Unit1_TreeView.Data;

namespace Unit1_TreeView
{
    public partial class frmAdvanced : Form
    {
        public frmAdvanced()
        {
            InitializeComponent();
        }

        private frmBasic basic = null;
        private frmListBox listBox = null;
        private Unit1_TreeView.Data.Data myData = new Unit1_TreeView.Data.Data();
        private int levelOfNode = -1;
        private bool flagColor = false;
        private int select = -1;

        private void frmAdvanced_Load(object sender, EventArgs e)
        {
            MessageBox.Show("1.Loi phan them People xoa nullPeople\n2.Xoa node null o root khong co phan tu\n3.Them anh cho ListBox");
            myData.getData();
            tvDisplay.ContextMenuStrip = contextMenuStrip;

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "TreeView - Perform data";

            dtBirthday.Format = DateTimePickerFormat.Custom;
            dtBirthday.CustomFormat = "dd-MM-yyyy";
            btnOK.Enabled = false;
            btnCancel.Enabled = false;

            foreach (Job itemJob in myData.listJob)
            {
                cbxJob.Items.Add(itemJob);
            }
            cbxJob.DisplayMember = "name";

            loadData();

            DialogResult result = MessageBox.Show("Do you want to expand all TreeView???", "Question", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                tvDisplay.ExpandAll();
            }
        }

        private void loadData()
        {
            tvDisplay.Nodes.Clear();
            foreach (Job itemJob in myData.listJob)
            {
                TreeNode nodeJob = new TreeNode(itemJob.name);
                // Rat quan trong
                nodeJob.Tag = itemJob;
                tvDisplay.Nodes.Add(nodeJob);
                if (itemJob.listPeople.Count > 0)
                {
                    foreach (People itemPeople in itemJob.listPeople)
                    {
                        TreeNode nodePeople = new TreeNode(itemPeople.name);
                        // Rat quan trong
                        nodePeople.Tag = itemPeople;
                        nodeJob.Nodes.Add(nodePeople);
                    }
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        People nullPeople = new People(-1, "null", false, dtBirthday.MaxDate);
                        itemJob.addData(nullPeople);

                        TreeNode nullItem = new TreeNode(nullPeople.name);
                        nullItem.Tag = nullPeople;
                        nodeJob.Nodes.Add(nullItem);
                    }
                }
            }
        }

        // Co tac dung giu nguyen Focus vao TreeNode khi su dung ContextMenuStrip
        private void tvDisplay_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvDisplay.SelectedNode = e.Node;
        }

        // Hien thi Data cua 1 TreeNode raa ngoai bang thuoc tinh Tag
        private void tvDisplay_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Kiem tra co chon TreeNode nao hay khong 
            if (e.Node != null)
            {
                if (e.Node.Level == 0)
                {
                    levelOfNode = 0;
                }
                else if (e.Node.Level == 1)
                {
                    levelOfNode = 1;
                }
            }
            displayData(e);
        }

        private void displayData(TreeViewEventArgs e)
        {
            if (levelOfNode == 0)
            {
                Job chooseJob = e.Node.Tag as Job;
                txtID.Text = chooseJob.ID.ToString();
                txtName.Text = chooseJob.name;

                lbInfo.Items.Clear();
                lbInfo.Items.Add("ID: " + chooseJob.ID);
                lbInfo.Items.Add("Name: " + chooseJob.name);
            }
            else if (levelOfNode == 1)
            {
                People choosePeople = e.Node.Tag as People;
                txtID.Text = choosePeople.ID.ToString();
                txtName.Text = choosePeople.name;
                txtGender.Text = choosePeople.gender == true ? "Male" : "Female";
                dtBirthday.Value = choosePeople.birthday;
                cbxJob.Text = choosePeople.theirJob.name;

                lbInfo.Items.Clear();
                lbInfo.Items.Add("ID: " + choosePeople.ID);
                lbInfo.Items.Add("Name: " + choosePeople.name);
                // Khong su dung dc toan tu 3 ngoi vi khong dc noi string vs bool
                if (choosePeople.gender == true)
                {
                    lbInfo.Items.Add("Gender: Male");
                }
                else
                {
                    lbInfo.Items.Add("Gender: Female");
                }
                lbInfo.Items.Add("Birthday: " + choosePeople.birthday.ToString("dd-MM-yyyy"));
                lbInfo.Items.Add("Job: " + choosePeople.theirJob.name);
            }
        }

        private void lbInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox != null)
            {
                listBox.Dispose();
            }
            listBox = new frmListBox();
            listBox.Show();
        }

        private void contextAddNode_Click(object sender, EventArgs e)
        {
            if (tvDisplay.SelectedNode != null)
            {
                select = 0;
                this.Text = "TreeView - Add node";
                btnOK.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void contextUpdateNode_Click(object sender, EventArgs e)
        {
            if (tvDisplay.SelectedNode != null)
            {
                select = 1;
                this.Text = "TreeView - Update node";
                btnOK.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void contextDeleteNode_Click(object sender, EventArgs e)
        {
            if (tvDisplay.SelectedNode != null)
            {
                select = 2;
                this.Text = "TreeView - Del node";
                btnOK.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void contextExpand_Click(object sender, EventArgs e)
        {
            if (tvDisplay.SelectedNode != null)
            {
                tvDisplay.SelectedNode.Expand();
            }
        }

        private void contextCollapse_Click(object sender, EventArgs e)
        {
            if (tvDisplay.SelectedNode != null)
            {
                tvDisplay.SelectedNode.Collapse();
            }
        }

        private void contextPerformColor_Click(object sender, EventArgs e)
        {
            if (flagColor == false)
            {
                flagColor = true;
                foreach (TreeNode root in tvDisplay.Nodes)
                {
                    root.ForeColor = Color.Red;
                    foreach (TreeNode item in root.Nodes)
                    {
                        item.ForeColor = Color.Green;
                    }
                }
            }
            else
            {
                flagColor = false;
                foreach (TreeNode root in tvDisplay.Nodes)
                {
                    root.ForeColor = Color.Black;
                    foreach (TreeNode item in root.Nodes)
                    {
                        item.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void contextOpen_Click(object sender, EventArgs e)
        {
            if (basic != null)
            {
                basic.Dispose();
            }
            basic = new frmBasic();
            basic.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // add node
            if (select == 0)
            {
                //try
                //{
                // Truong hop nay se khong bao gio xay ra
                if (tvDisplay.SelectedNode == null)
                {
                    Job addJob = new Job(-1000, "Khong bao gio xay ra");
                    myData.listJob.Add(addJob);

                    TreeNode addNode = new TreeNode(addJob.name);
                    addNode.Tag = addJob;

                    tvDisplay.Nodes.Add(addNode);

                    cbxJob.Items.Clear();
                    foreach (Job itemJob in myData.listJob)
                    {
                        cbxJob.Items.Add(itemJob);
                    }
                    cbxJob.DisplayMember = "name";
                }
                else
                {
                    // Neu chon nodeJob thi se add nodePeople vao nodeJob
                    if (tvDisplay.SelectedNode.Level == 0)
                    {
                        /// Them TreeNode
                        if (string.IsNullOrEmpty(cbxJob.Text))
                        {
                            People addPeople = null;
                            Job existJob = tvDisplay.SelectedNode.Tag as Job;
                            if (txtGender.Text == "Male")
                            {
                                addPeople = new People(int.Parse(txtID.Text), txtName.Text, true, dtBirthday.Value);
                            }
                            else if (txtGender.Text == "Female")
                            {
                                addPeople = new People(int.Parse(txtID.Text), txtName.Text, false, dtBirthday.Value);
                            }
                            existJob.addData(addPeople);

                            TreeNode addNode = new TreeNode(addPeople.name);
                            addNode.Tag = addPeople;
                            tvDisplay.SelectedNode.Nodes.Add(addNode);

                            for (int i = 0; i < existJob.listPeople.Count; i++)
                            {
                                if (existJob.listPeople[i].ID < 0)
                                {
                                    existJob.listPeople.Remove(existJob.listPeople[i]);
                                }
                            }
                            /// Error -__-
                            for (int i = 0; i < tvDisplay.Nodes[existJob.name].Nodes.Count; i++)
                            {
                                if (tvDisplay.Nodes[existJob.name].Nodes[i].Text == "null")
                                {
                                    tvDisplay.Nodes[existJob.name].Nodes[i].Remove();
                                }
                            }
                        }
                        else
                        {
                            People addPeople = null;
                            Job existJob = cbxJob.SelectedItem as Job;
                            if (txtGender.Text == "Male")
                            {
                                addPeople = new People(int.Parse(txtID.Text), txtName.Text, true, dtBirthday.Value);
                            }
                            else if (txtGender.Text == "Female")
                            {
                                addPeople = new People(int.Parse(txtID.Text), txtName.Text, false, dtBirthday.Value);
                            }
                            existJob.addData(addPeople);

                            TreeNode addNode = new TreeNode(addPeople.name);
                            addNode.Tag = addPeople;
                            foreach (TreeNode node in tvDisplay.Nodes)
                            {
                                if (node.Tag as Job == existJob)
                                {
                                    node.Nodes.Add(addNode);
                                }
                            }
                            for (int i = 0; i < existJob.listPeople.Count; i++)
                            {
                                if (existJob.listPeople[i].ID < 0)
                                {
                                    existJob.listPeople.Remove(existJob.listPeople[i]);
                                }
                            }
                            for (int i = 0; i < tvDisplay.Nodes[cbxJob.SelectedIndex].Nodes.Count; i++)
                            {
                                if (tvDisplay.Nodes[cbxJob.SelectedIndex].Nodes[i].Text == "null")
                                {
                                    tvDisplay.Nodes[cbxJob.SelectedIndex].Nodes[i].Remove();
                                }
                            }
                        }
                    }
                    // Muon chon nodePeople thi se add nodeJob vao TreeView
                    else
                    {
                        Job addJob = new Job(int.Parse(txtID.Text), txtName.Text);
                        myData.listJob.Add(addJob);

                        TreeNode addNode = new TreeNode(addJob.name);
                        addNode.Tag = addJob;

                        for (int i = 0; i < 4; i++)
                        {
                            People nullPeople = new People(-1, "null", false, dtBirthday.MaxDate);
                            addJob.addData(nullPeople);

                            TreeNode nullItem = new TreeNode(nullPeople.name);
                            nullItem.Tag = nullPeople;
                            addNode.Nodes.Add(nullItem);
                        }
                        tvDisplay.Nodes.Add(addNode);

                        cbxJob.Items.Clear();
                        foreach (Job itemJob in myData.listJob)
                        {
                            cbxJob.Items.Add(itemJob);
                        }
                        cbxJob.DisplayMember = "name";
                    }
                    //    }
                    //}
                    //catch
                    //{
                    //    MessageBox.Show("Error");
                }
            }
            // update node
            else if (select == 1)
            {
                if (tvDisplay.SelectedNode.Level == 0)
                {
                    Job updateJob = tvDisplay.SelectedNode.Tag as Job;
                    updateJob.ID = int.Parse(txtID.Text);
                    updateJob.name = txtName.Text;

                    cbxJob.Items.Clear();
                    foreach (Job itemJob in myData.listJob)
                    {
                        cbxJob.Items.Add(itemJob);
                    }
                    cbxJob.DisplayMember = "name";

                    TreeNode updateNode = tvDisplay.SelectedNode;
                    updateNode.Text = updateJob.name;
                    // Co 2 dong tren nen dong nay khong can thiet
                    // tvDisplay.SelectedNode.Tag = updateJob;
                }
                /// Thieu truong hop update khac job
                else if (tvDisplay.SelectedNode.Level == 1)
                {
                    Job existJob = cbxJob.SelectedItem as Job;
                    People updatePeople = tvDisplay.SelectedNode.Tag as People;
                    updatePeople.ID = int.Parse(txtID.Text);
                    updatePeople.name = txtName.Text;
                    if (txtGender.Text == "Male")
                    {
                        updatePeople.gender = true;
                    }
                    else if (txtGender.Text == "Female")
                    {
                        updatePeople.gender = false;
                    }
                    updatePeople.birthday = dtBirthday.Value;

                    // Khong can cau nay do Tag thay doi thi TreeNode.Tag cung tu thay doi theo
                    //tvDisplay.SelectedNode.Tag = updatePeople;
                    TreeNode updateNode = tvDisplay.SelectedNode;
                    updateNode.Text = updatePeople.name;
                }
            }
            // del node
            else if (select == 2)
            {
                if (tvDisplay.SelectedNode.Level == 0)
                {
                    Job delJob = tvDisplay.SelectedNode.Tag as Job;
                    myData.listJob.Remove(delJob);

                    tvDisplay.SelectedNode.Remove();

                    cbxJob.Items.Remove(delJob);
                }
                else if (tvDisplay.SelectedNode.Level == 1)
                {
                    People delPeople = tvDisplay.SelectedNode.Tag as People;
                    Job existJob = cbxJob.SelectedItem as Job;
                    existJob.listPeople.Remove(delPeople);

                    tvDisplay.SelectedNode.Remove();
                }
            }
            btnOK.Enabled = false;
            btnCancel.Enabled = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
            btnCancel.Enabled = false;
        }
    }
}
