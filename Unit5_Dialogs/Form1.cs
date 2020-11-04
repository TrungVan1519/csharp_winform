using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit5_Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// OpenFileDialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetImage_Click_1(object sender, EventArgs e)
        {
            btnGetImage.AutoSize = true;

            openFileDialog.Filter = "Ảnh PNG|*.png|Ảnh Bitmap|*.bmp|Tất cả|*.*";
            openFileDialog.FileName = "Chọn ảnh đi anh zai, chị gái :v";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        /// <summary>
        /// SaveFileDialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            btnSaveFile.AutoSize = true;

            saveFileDialog.Filter = "File Txt|*.txt|Tất cả các kiểu File|*.*";
            saveFileDialog.FileName = "Save";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Đoạn code này có ý nghĩa giới thiệu việc lưu File\nSau này sẽ học kỹ hơn về lưu File");
            }
            else
            {
                MessageBox.Show("Bạn chưa lưu File");
            }
        }

        /// <summary>
        /// ColorDialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            btnChangeColor.AutoSize = true;

            colorDialog.Color = btnChangeColor.BackColor;
            colorDialog.Color = panel.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnChangeColor.BackColor = colorDialog.Color;
                panel.BackColor = colorDialog.Color;
            }
        }

        bool choose = false;
        private void btnChangeSize_Click(object sender, EventArgs e)
        {
            btnChangeSize.AutoSize = true;

            if (choose == false)
            {
                choose = true;
                colorDialog.AllowFullOpen = true;
                colorDialog.FullOpen = true;
            }
            else
            {
                choose = false;
                colorDialog.AllowFullOpen = false;
                colorDialog.FullOpen = false;
            }
        }

        /// <summary>
        /// FontDialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            btnChangeFont.AutoSize = true;

            fontDialog.Font = btnChangeFont.Font;
            fontDialog.Font = lbExample.Font;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                btnChangeFont.Font = fontDialog.Font;
                lbExample.Font = fontDialog.Font;
            }
        }
        /// <summary>
        /// FolderBrowserDialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txbPath.ReadOnly = true;
                txbPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Tất cả|*.*";
            saveFileDialog.FileName = "Chọn chỗ để xếp";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Đoạn code này có ý nghĩa giới thiệu việc lưu File\nSau này sẽ học kỹ hơn về lưu File");
            }
            else
            {
                MessageBox.Show("Bạn chưa lưu File");
            }
        }
    }
}
