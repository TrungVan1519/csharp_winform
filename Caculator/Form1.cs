using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Chuoi hien thi man hinh
        private string hienThi = "";
        // Chuoi lay phep tinh
        private string phepTinh = "";
        // Dem so phep tinh nhap vao ( vi hien tai la tinh cho 2 so nen neu co 2 phep tinh thi se bao )
        private int count;


        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            hienThi += "0";
            rtxbHienThi.Text = hienThi;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            hienThi += "1";
            rtxbHienThi.Text = hienThi;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            hienThi += "2";
            rtxbHienThi.Text = hienThi;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            hienThi += "3";
            rtxbHienThi.Text = hienThi;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            hienThi += "4";
            rtxbHienThi.Text = hienThi;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            hienThi += "5";
            rtxbHienThi.Text = hienThi;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            hienThi += "6";
            rtxbHienThi.Text = hienThi;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            hienThi += "7";
            rtxbHienThi.Text = hienThi;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            hienThi += "8";
            rtxbHienThi.Text = hienThi;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            hienThi += "9";
            rtxbHienThi.Text = hienThi;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            rtxbHienThi.Clear();
            rtxbHienThi.ForeColor = Color.Black;
            rtxbHienThi.Font = new Font(rtxbHienThi.Font, FontStyle.Regular);
            hienThi = "";
            count = 0;
        }
        private void btnDEL_Click(object sender, EventArgs e)
        {
            rtxbHienThi.Text = "Chua lap trinh toi :s\n[ AC ] : Cancel";
            rtxbHienThi.ForeColor = Color.Green;
            rtxbHienThi.Font = new Font(rtxbHienThi.Font, FontStyle.Italic);
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            phepTinh = " x ";
            hienThi += " x ";
            rtxbHienThi.Text = hienThi;
            count++;
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            phepTinh = " / ";
            hienThi += " / ";
            rtxbHienThi.Text = hienThi;
            count++;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            phepTinh = " + ";
            hienThi += " + ";
            rtxbHienThi.Text = hienThi;
            count++;
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            phepTinh = " - ";
            hienThi += " - ";
            rtxbHienThi.Text = hienThi;
            count++;
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                rtxbHienThi.Text += "\n\n" + hienThi;
            }
            else if (count == 1)
            {
                int num1, num2;
                string[] arrString;

                arrString = hienThi.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    num1 = int.Parse(arrString[0]);
                    num2 = int.Parse(arrString[2]);

                    if (string.Equals(phepTinh, " x "))
                    {
                        rtxbHienThi.Text += "\n\n" + (num1 * num2).ToString();
                    }

                    else if (phepTinh.CompareTo(" / ") == 0)
                    {
                        rtxbHienThi.Text += "\n\n" + (num1 / num2).ToString();
                    }

                    else if (phepTinh.CompareTo(" + ") == 0)
                    {
                        rtxbHienThi.Text += "\n\n" + (num1 + num2).ToString();
                    }

                    else if (string.Equals(phepTinh, " - "))
                    {
                        rtxbHienThi.Text += "\n\n" + (num1 - num2).ToString();
                    }
                }
                catch (Exception)
                {
                    rtxbHienThi.Text = "Syntax ERROR\n[ AC ] : Cancel";
                    rtxbHienThi.ForeColor = Color.Red;
                    rtxbHienThi.Font = new Font(rtxbHienThi.Font, FontStyle.Italic);
                }
            }
            else
            {
                rtxbHienThi.Text = "Chua lap trinh toi :s\n[ AC ] : Cancel";
                rtxbHienThi.ForeColor = Color.Green;
                rtxbHienThi.Font = new Font(rtxbHienThi.Font, FontStyle.Italic);
            }
        }
    }
}
