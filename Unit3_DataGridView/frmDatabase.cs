using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Unit3_DataGridView.Data;

namespace Unit3_DataGridView
{
    public partial class frmDatabase : Form
    {
        public frmDatabase()
        {
            InitializeComponent();
        }


        private Data.Data myDatabase = new Data.Data();

        private void frmDatabase_Load(object sender, EventArgs e)
        {
            //txbID.ReadOnly = true;
            //txbName.ReadOnly = true;
            //txbGender.ReadOnly = true;
        }

        private void dataGVDisplay_Click(object sender, EventArgs e)
        {
            int index = dataGVDisplay.CurrentRow.Index;
            txbID.Text = dataGVDisplay.Rows[index].Cells[0].Value.ToString();
            txbName.Text = dataGVDisplay.Rows[index].Cells[1].Value.ToString();
            txbGender.Text = dataGVDisplay.Rows[index].Cells[2].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Perform()
        {
            try
            {
                myDatabase.Connect();
                this.dataGVDisplay.DataSource = myDatabase.Table();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                myDatabase.Disconnect();
            }
        }

        private void btnPerform_Click(object sender, EventArgs e)
        {
            Perform();
        }

        private void Add()
        {
            try
            {
                myDatabase.Connect();
                myDatabase.Add(txbID.Text, txbName.Text, txbGender.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                myDatabase.Disconnect();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            Perform();
        }

        private void Del()
        {
            try
            {
                myDatabase.Connect();
                myDatabase.Del(txbID.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                myDatabase.Disconnect();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Del();
            Perform();
        }

        private void Update()
        {
            try
            {
                myDatabase.Connect();
                myDatabase.Update(txbID.Text, txbName.Text, txbGender.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                myDatabase.Disconnect();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
            Perform();
        }
    }
}
