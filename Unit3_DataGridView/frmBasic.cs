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
    public partial class frmBasic : Form
    {
        public frmBasic()
        {
            InitializeComponent();
        }

        private List<NhanVien> danhSach = new List<NhanVien>();

        private void Lay_Du_Lieu()
        {
            NhanVien nhanVien1 = new NhanVien();
            nhanVien1.Ten = "Dao";
            nhanVien1.Ma = 1;
            nhanVien1.SDT = 1;

            NhanVien nhanVien2 = new NhanVien();
            nhanVien2.Ma = 2;
            nhanVien2.Ten = "Van";
            nhanVien2.SDT = 2;

            NhanVien nhanVien3 = new NhanVien();
            nhanVien3.Ma = 3;
            nhanVien3.Ten = "Trung";
            nhanVien3.SDT = 3;

            danhSach.Add(nhanVien1);
            danhSach.Add(nhanVien2);
            danhSach.Add(nhanVien3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lay_Du_Lieu();
            dataGVDisplay.DataSource = danhSach;
        }

        private void dataGVDisplay_Click(object sender, EventArgs e)
        {
            int index = dataGVDisplay.CurrentRow.Index;
            // Cách 1: Tường minh
            DataGridViewRow chooseRow = dataGVDisplay.Rows[index];
            txbMa.Text = chooseRow.Cells[0].Value.ToString();
            txbTen.Text = chooseRow.Cells[1].Value.ToString();
            txbSDT.Text = chooseRow.Cells[2].Value.ToString();
            // Cách 2: Nhanh gọn
            txbMa.Text = dataGVDisplay.Rows[index].Cells[0].Value.ToString();
            txbTen.Text = dataGVDisplay.Rows[index].Cells[1].Value.ToString();
            txbSDT.Text = dataGVDisplay.Rows[index].Cells[2].Value.ToString();
        }
    }
}
