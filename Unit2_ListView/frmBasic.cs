using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Unit2_ListView.Data;

namespace Unit2_ListView
{
    public partial class frmBasic : Form
    {
        public frmBasic()
        {
            InitializeComponent();
        }

        private Data.Data myData = new Data.Data();

        private void frmListView_Basic_Load(object sender, EventArgs e)
        {
            myData.getData();

            // Cua ListView
            lvDisplay.FullRowSelect = true;
            lvDisplay.GridLines = true;
            lvDisplay.HideSelection = false;
            lvDisplay.View = View.Details;

        }

        private void lvDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDisplay.SelectedItems.Count > 0)
            {
                txbID.Text = lvDisplay.SelectedItems[0].Text;
                txbName.Text = lvDisplay.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void lvDisplay_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != -1)
            {
                ColumnHeader column = lvDisplay.Columns[e.Column];
                MessageBox.Show(column.Text);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            lvDisplay.Clear();
            lvDisplay.Groups.Clear();

            ColumnHeader columnID = new ColumnHeader();
            columnID.Text = "ID";
            columnID.TextAlign = HorizontalAlignment.Center;
            columnID.Width = 100;
            lvDisplay.Columns.Add(columnID);

            ColumnHeader columnName = new ColumnHeader();
            columnName.Text = "Name";
            columnName.TextAlign = HorizontalAlignment.Center;
            columnName.Width = 200;
            lvDisplay.Columns.Add(columnName);

            foreach (Job itemJob in myData.listJob)
            {
                ListViewItem item = new ListViewItem(itemJob.ID.ToString());
                item.SubItems.Add(itemJob.name);
                // Rat quan trong
                item.Tag = itemJob;
                lvDisplay.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem addItem = new ListViewItem(txbID.Text);
            addItem.SubItems.Add(txbName.Text);
            lvDisplay.Items.Add(addItem);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvDisplay.SelectedItems.Count > 0)
            {
                ListViewItem delItem = lvDisplay.SelectedItems[0];
                lvDisplay.Items.Remove(delItem);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvDisplay.SelectedItems.Count > 0)
            {
                ListViewItem updateItem = lvDisplay.SelectedItems[0];
                updateItem.SubItems[0].Text = txbID.Text;
                updateItem.SubItems[1].Text = txbName.Text;
            }
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            performData();
        }
        private void performData()
        {
            lvDisplay.Clear();
            lvDisplay.Groups.Clear();

            ColumnHeader columnID = new ColumnHeader();
            columnID.Text = "ID";
            columnID.TextAlign = HorizontalAlignment.Center;
            columnID.Width = 100;
            lvDisplay.Columns.Add(columnID);

            ColumnHeader columnName = new ColumnHeader();
            columnName.Text = "Name";
            columnName.TextAlign = HorizontalAlignment.Center;
            columnName.Width = 200;
            lvDisplay.Columns.Add(columnName);

            ColumnHeader columnGender = new ColumnHeader();
            columnGender.Text = "Gender";
            columnGender.TextAlign = HorizontalAlignment.Center;
            columnGender.Width = 200;
            lvDisplay.Columns.Add(columnGender);

            ColumnHeader ColumnBirthday = new ColumnHeader();
            ColumnBirthday.Text = "Birthday";
            ColumnBirthday.TextAlign = HorizontalAlignment.Center;
            ColumnBirthday.Width = 200;
            lvDisplay.Columns.Add(ColumnBirthday);

            foreach (Job itemJob in myData.listJob)
            {
                ListViewGroup itemGroup = new ListViewGroup(itemJob.name);
                // Rat quan trong
                itemGroup.Tag = itemJob;
                lvDisplay.Groups.Add(itemGroup);
                if (itemJob.listPeople.Count > 0)
                {
                    foreach (People itemPeople in itemJob.listPeople)
                    {
                        ListViewItem item = new ListViewItem(itemPeople.ID.ToString());
                        item.SubItems.Add(itemPeople.name);
                        item.SubItems.Add(itemPeople.gender == true ? "Male" : "Female");
                        item.SubItems.Add(itemPeople.birthday.ToString("dd-MM-yyyy"));
                        // Quan trong
                        item.Group = itemGroup;
                        // Rat quan trong
                        item.Tag = itemPeople;
                        lvDisplay.Items.Add(item);
                    }
                }
            }
        }
    }
}
