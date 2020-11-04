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
    public partial class frmAdvanced : Form
    {
        public frmAdvanced()
        {
            InitializeComponent();
        }

        private frmBasic basic = null;
        private Data.Data myData = new Data.Data();
        private Data.Data backUp = new Data.Data();
        private frmListBox listBox = null;
        private int select = -1;

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("1. Thieu truong hop update People ma doi Job\n2. Button Undo\n3. Them anh cho frmListBox", "To be continued", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // Lay du lieu -__- nay de cai nay o ham PerformClick nen ComboBox va loadData khong hien thi data -___-
            myData.getData();

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            dtBirthday.Format = DateTimePickerFormat.Custom;
            dtBirthday.CustomFormat = "dd-MM-yyyy";
            splitContainer2.Panel1.Visible = false;
            splitContainer2.Panel1.Enabled = false;
            // Cua ListView
            lvDisplay.FullRowSelect = true;
            lvDisplay.GridLines = true;
            lvDisplay.HideSelection = false;
            lvDisplay.View = View.Details;
            // Cua ComboBox
            //// Cach 1: Singer se bi chon luon
            //cbxJob.DataSource = myData.listJob;
            // Cach 2: Khong co cai nao bi chon truoc nen su dung dc truong hop select == -1
            foreach (Job itemJob in myData.listJob)
            {
                cbxJob.Items.Add(itemJob);
            }
            cbxJob.DisplayMember = "name";

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

        private void btnPerform_Click(object sender, EventArgs e)
        {
            if (cbxJob.SelectedItem == null)
            {
                if (select == -1)
                {
                    select = 0;
                    performData();
                }
                else
                {
                    select = -1;
                    loadData();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(cbxJob.Text))
                {
                    select = -1;
                    loadData();
                }
                else
                {
                    select = 1;
                    performData();
                }
            }
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

            if (select == 0)
            {
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
                    /// Neu them vao ListView 1 Group ( 1 Job ) moi ma khong co ListViewItem nao thi ListView se khong hien ra Group do
                    /// Nen ta them 1 ListViewItem null mac dinh cho cac Group nay de co the thay ListView dc chia thanh cac Group ro rang hon
                    else
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            People nullPeople = new People(-1, "null", false, dtBirthday.MaxDate);
                            itemJob.addData(nullPeople);

                            ListViewItem nullItem = new ListViewItem("-1");
                            nullItem.SubItems.Add("null");
                            nullItem.SubItems.Add("null");
                            nullItem.SubItems.Add("null");
                            nullItem.Group = itemGroup;
                            nullItem.Tag = nullPeople;
                            lvDisplay.Items.Add(nullItem);
                        }
                    }
                }
            }
            else
            {
                Job itemJob = cbxJob.SelectedItem as Job;
                if (itemJob.listPeople.Count > 0)
                {
                    foreach (People itemPeople in itemJob.listPeople)
                    {
                        ListViewItem item = new ListViewItem(itemPeople.ID.ToString());
                        item.SubItems.Add(itemPeople.name);
                        item.SubItems.Add(itemPeople.gender == true ? "Male" : "Female");
                        item.SubItems.Add(itemPeople.birthday.ToString("dd-MM-yyyy"));
                        // Rat quan trong
                        item.Tag = itemPeople;
                        lvDisplay.Items.Add(item);
                    }
                }
                /// Neu them vao ListView 1 Group ( 1 Job ) moi ma khong co ListViewItem nao thi ListView se khong hien ra Group do
                /// Nen ta them 1 ListViewItem null mac dinh cho cac Group nay de co the thay ListView dc chia thanh cac Group ro rang hon
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        People nullPeople = new People(-1, "null", false, dtBirthday.MaxDate);
                        itemJob.addData(nullPeople);

                        ListViewItem nullItem = new ListViewItem("-1");
                        nullItem.SubItems.Add("null");
                        nullItem.SubItems.Add("null");
                        nullItem.SubItems.Add("null");
                        nullItem.Tag = nullPeople;
                        lvDisplay.Items.Add(nullItem);
                    }
                }
            }
        }

        int sortColumn = -1;
        private void lvDisplay_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //if (e.Column != sortColumn)
            //{
            //    // Set the sort column to the new column.
            //    sortColumn = e.Column;
            //    // Set the sort order to ascending by default.
            //    lvDisplay.Sorting = SortOrder.Ascending;
            //}
            //else
            //{
            //    // Determine what the last sort order was and change it.
            //    if (lvDisplay.Sorting == SortOrder.Ascending)
            //        lvDisplay.Sorting = SortOrder.Descending;
            //    else
            //        lvDisplay.Sorting = SortOrder.Ascending;
            //}

            //// Call the sort method to manually sort.
            //lvDisplay.Sort();
        }

        private void lvDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Phai co if nay thi moi chon dc cac Items khac nhau trong ListView
            if (lvDisplay.SelectedItems.Count > 0)
            {
                splitContainer2.Panel1.Visible = true;
                splitContainer2.Panel1.Enabled = true;
                if (select == -1)
                {
                    Job chooseJob = lvDisplay.SelectedItems[0].Tag as Job;

                    txtID.Text = chooseJob.ID.ToString();
                    txtName.Text = chooseJob.name;

                    lbInfo.Items.Clear();
                    lbInfo.Items.Add("ID: " + chooseJob.ID);
                    lbInfo.Items.Add("Name: " + chooseJob.name);
                }

                else if (select == 0 || select == 1)
                {
                    People choosePeople = lvDisplay.SelectedItems[0].Tag as People;
                    if (choosePeople.ID > 0)
                    {
                        txtID.Text = lvDisplay.SelectedItems[0].Text;
                        txtName.Text = lvDisplay.SelectedItems[0].SubItems[1].Text;
                        txtGender.Text = lvDisplay.SelectedItems[0].SubItems[2].Text;
                        // Neu dung cai nay thi se ra true, false chu khong ra dinh dang dd-MM-yyyy
                        //txtGender.Text = choosePeople.gender.ToString();
                        dtBirthday.Value = choosePeople.birthday;
                        cbxJob.Text = choosePeople.theirJob.name;

                        lbInfo.Items.Clear();
                        lbInfo.Items.Add("ID: " + choosePeople.ID);
                        lbInfo.Items.Add("Name: " + choosePeople.name);
                        // Tai sao cho nay khong su dung toan tu 3 ngoi nhu tren? Thi la do khong dc phep noi giua kieu string vs kieu bool :v
                        // Vay thi sao ta khong truyen bien de su dung toan tu 3 ngoi? Thi do ham Add() khong co OverLoad() co 2 doi so -___-
                        // Toi chot nhan ra tai sao ta khong don gian hon bang cach + vs txtGender.Text o tren??
                        //      + Do txtGender.Text o tren toi lay du lieu bang cach ListView.SelectedItems[0].SubItems[2].Text nen gender se dc chuyen ve dinh dang dd-MM-yyyy luon do ham performData()
                        //      + Con vs lbInfor.Items.Add() thi toi su dung thuoc tinh ListViewItem.Tag as Object de lay du lieu 
                        //      + Va toi muon kiem tra xem 2 cach lay nay co tra ve cung du lieu hay khong? Neu dung thi ta lam dung, con khong thi ta bi sai o dau do
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
                    else
                    {
                        txtID.Text = "-1";
                        txtName.Text = "NULL";
                        txtGender.Text = "NULL";
                        dtBirthday.Value = choosePeople.birthday;
                        cbxJob.Text = choosePeople.theirJob.name;

                        lbInfo.Items.Clear();
                        lbInfo.Items.Add(txtID.Text);
                        lbInfo.Items.Add(txtName.Text);
                        lbInfo.Items.Add(txtGender.Text);
                        lbInfo.Items.Add(dtBirthday.Text);
                        lbInfo.Items.Add(cbxJob.Text);
                    }
                }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (select == -1)
            {
                Job addJob = new Job(int.Parse(txtID.Text), txtName.Text);
                myData.listJob.Add(addJob);

                ListViewItem addItem = new ListViewItem(addJob.ID.ToString());
                addItem.SubItems.Add(addJob.name);
                // Rat quan trong
                addItem.Tag = addJob;
                lvDisplay.Items.Add(addItem);

                cbxJob.Items.Clear();
                foreach (Job itemJob in myData.listJob)
                {
                    cbxJob.Items.Add(itemJob);
                }
                cbxJob.DisplayMember = "name";
            }
            else
            {
                /// Them ListViewItem vao ListView
                People addPeople = null;
                Job existJob = cbxJob.SelectedItem as Job;
                if (txtGender.Text == "Male")
                {
                    addPeople = new People(int.Parse(txtID.Text), txtName.Text, true, dtBirthday.Value);
                    existJob.addData(addPeople);
                }
                else if (txtGender.Text == "Female")
                {
                    addPeople = new People(int.Parse(txtID.Text), txtName.Text, false, dtBirthday.Value);
                    existJob.listPeople.Add(addPeople);
                    addPeople.theirJob = existJob;
                }

                ListViewItem addItem = new ListViewItem(txtID.Text);
                addItem.SubItems.Add(addPeople.name);
                addItem.SubItems.Add(addPeople.gender == true ? "Male" : "Female");
                addItem.SubItems.Add(addPeople.birthday.ToString("dd-MM-yyyy"));
                if (select == 0)
                {
                    // Quan trong
                    // Cach 1: Chac chan ngon an nhung phai co ComboBox 
                    addItem.Group = lvDisplay.Groups[cbxJob.SelectedIndex];
                    // Cach 2: Hoi lang nhang hon 1 chut va cung khong can phai co ComboBox nhung phai de existJob.ID la duy nhat ( khoa chinh ), neu khong se tac dong den sai Group
                    //addItem.Group = lvDisplay.Groups[existJob.ID - 1];
                }
                // Rat quan trong
                addItem.Tag = addPeople;
                lvDisplay.Items.Add(addItem);

                /// Xoa ListViewItem null neu nhu ta them ListViewItem vao dung Group.Count = 0 ma ta da them ListViewItem null o tren ham performData() o tren
                if (select == 0)
                {
                    //Cach 1: Khong su dung foreach dc vi foreach khong cho phep xoa, them item trong collection
                    for (int i = 0; i < existJob.listPeople.Count; i++)
                    {
                        if (existJob.listPeople[i].ID < 0)
                        {
                            existJob.listPeople.Remove(existJob.listPeople[i]);
                        }
                    }

                    for (int i = 0; i < lvDisplay.Groups[cbxJob.SelectedIndex].Items.Count; i++)
                    {
                        if (int.Parse(lvDisplay.Groups[cbxJob.SelectedIndex].Items[i].Text) < 0)
                        {
                            // Loi them Group -__- 
                            //lvDisplay.Groups[cbxJob.SelectedIndex].Items.Remove(lvDisplay.Groups[cbxJob.SelectedIndex].Items[i]);
                            lvDisplay.Groups[cbxJob.SelectedIndex].Items[i].Remove();
                        }
                        //if (string.Compare(lvDisplay.Groups[cbxJob.SelectedIndex].Items[i].SubItems[1].Text, "null") == 0)
                        //{
                        //    //Loi~
                        //    lvDisplay.Groups[cbxJob.SelectedIndex].Items.Remove(lvDisplay.Groups[cbxJob.SelectedIndex].Items[i]);
                        //}
                    }

                    // Cach 2: Dang bi loi null lvDisplay.Groups[existGroup.name]
                    //Job existGroup = lvDisplay.Groups[cbxJob.SelectedIndex].Tag as Job;
                    //for (int i = 0; i < existGroup.listPeople.Count; i++)
                    //{
                    //    if (existGroup.listPeople[i].ID < 0)
                    //    {
                    //        existGroup.listPeople.Remove(existGroup.listPeople[i]);
                    //    }
                    //}
                    //for (int i = 0; i < lvDisplay.Groups[existGroup.name].Items.Count; i++)
                    //{
                    //    if (lvDisplay.Groups[existGroup.name].Items[i].SubItems[1].Text != "null")
                    //    {
                    //        lvDisplay.Groups[existGroup.name].Items[i].Remove();
                    //    }
                    //}
                }
                else
                {
                    for (int i = 0; i < existJob.listPeople.Count; i++)
                    {
                        if (existJob.listPeople[i].ID < 0)
                        {
                            existJob.listPeople.Remove(existJob.listPeople[i]);
                        }
                    }
                    for (int i = 0; i < lvDisplay.Items.Count; i++)
                    {
                        if (int.Parse(lvDisplay.Items[i].Text) < 0)
                        {
                            lvDisplay.Items[i].Remove();
                        }
                    }
                    //for (int i = lvDisplay.Items.Count - 1; i >= 0; i--)
                    //{
                    //    if (int.Parse(lvDisplay.Items[i].Text) < 0)
                    //    {
                    //        lvDisplay.Items[i].Remove();
                    //    }
                    //}
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvDisplay.SelectedItems.Count > 0)
            {
                if (select == -1)
                {
                    Job updateJob = lvDisplay.SelectedItems[0].Tag as Job;
                    updateJob.ID = int.Parse(txtID.Text);
                    updateJob.name = txtName.Text;

                    ListViewItem updateItem = lvDisplay.SelectedItems[0];
                    updateItem.Text = txtID.Text;
                    updateItem.SubItems[1].Text = txtName.Text;

                    cbxJob.Items.Clear();
                    foreach (Job itemJob in myData.listJob)
                    {
                        cbxJob.Items.Add(itemJob);
                    }
                    cbxJob.DisplayMember = "name";
                }
                else
                {
                    /// Thieu truog hop thay doi Job khi update
                    Job existJob = cbxJob.SelectedItem as Job;
                    People updatePerson = lvDisplay.SelectedItems[0].Tag as People;
                    updatePerson.ID = int.Parse(txtID.Text);
                    updatePerson.name = txtName.Text;
                    if (txtGender.Text == "Male")
                    {
                        updatePerson.gender = true;
                    }
                    else if (txtGender.Text == "Female")
                    {
                        updatePerson.gender = false;
                    }
                    updatePerson.birthday = dtBirthday.Value;

                    //Khong can phai lvDisplay.SelectedItems[0].Tag = updatePeople nua do Tag thay doi thi ListViewItem.Tag cung tu thay doi theo
                    ListViewItem updateItem = lvDisplay.SelectedItems[0];
                    updateItem.Text = txtID.Text;
                    updateItem.SubItems[1].Text = txtName.Text;
                    updateItem.SubItems[2].Text = txtGender.Text;
                    updateItem.SubItems[3].Text = dtBirthday.Value.ToString("dd-MM-yyyy");
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (select == -1)
            {
                Job delJob = null;
                if (cbxJob.SelectedItem == null /*or lvDisplay.SelectedItems[0] != null*/)
                {
                    delJob = lvDisplay.SelectedItems[0].Tag as Job;
                    lvDisplay.Items.Remove(lvDisplay.SelectedItems[0]);

                    cbxJob.SelectedItem = delJob;
                    cbxJob.Items.Remove(cbxJob.SelectedItem);
                }
                else
                {
                    delJob = cbxJob.SelectedItem as Job;
                    cbxJob.Items.Remove(cbxJob.SelectedItem);

                    foreach (ListViewItem delItem in lvDisplay.Items)
                    {
                        if (delItem.Tag as Job == delJob)
                        {
                            lvDisplay.Items.Remove(delItem);
                        }
                    }
                }
                myData.listJob.Remove(delJob);
            }
            else
            {
                Job existJob = cbxJob.SelectedItem as Job;
                People delPeople = lvDisplay.SelectedItems[0].Tag as People;

                for (int i = 0; i < existJob.listPeople.Count; i++)
                {
                    if (existJob.listPeople[i] == delPeople)
                    {
                        existJob.listPeople.Remove(existJob.listPeople[i]);
                    }
                }
                lvDisplay.SelectedItems[0].Remove();
                if (existJob.listPeople.Count == 0)
                {
                    People nullPeople = new People(-1, "null", false, dtBirthday.MaxDate);
                    existJob.addData(nullPeople);

                    // Cach 1: Tao 1 Group ms ( khuyen cao khong nen dung, chi la thu cho vui thoi :p )
                    //ListViewGroup nullGroup = new ListViewGroup(existJob.name);
                    //nullGroup.Tag = existJob;
                    //lvDisplay.Groups.Add(nullGroup);
                    //ListViewItem nullItem = new ListViewItem("-1");
                    //nullItem.SubItems.Add("null");
                    //nullItem.SubItems.Add("null");
                    //nullItem.SubItems.Add("null");
                    //nullItem.Group = nullGroup;
                    //nullItem.Tag = nullPeople;
                    //lvDisplay.Items.Add(nullItem);

                    // Cach 2: Su dung lai Group cu da co nhung bi ẩn di do khong co Item cua ListView
                    ListViewItem nullItem1 = new ListViewItem("-1");
                    nullItem1.SubItems.Add("null");
                    nullItem1.SubItems.Add("null");
                    nullItem1.SubItems.Add("null");
                    lvDisplay.Groups[cbxJob.SelectedIndex].Items.Add(nullItem1);
                    nullItem1.Tag = nullPeople;
                    lvDisplay.Items.Add(nullItem1);
                }
            }
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenBasic_Click(object sender, EventArgs e)
        {
            if (basic != null)
            {
                basic.Dispose();
            }
            basic = new frmBasic();
            basic.Show();
        }
    }
}
