using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Unit7_File.Data;
using System.IO;
using Microsoft.Office.Interop.Word;
using SautinSoft.Document;
using Xceed.Words.NET;
using iTextSharp.text.pdf;

namespace Unit7_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SaveFileDialog save = new SaveFileDialog();
        private OpenFileDialog open = new OpenFileDialog();
        private Data.Data data = new Data.Data();

        private void frmAllFile_Load(object sender, EventArgs e)
        {
            data.getData();

            this.WindowState = FormWindowState.Maximized;

            lbxExample.Items.Clear();
            foreach (People person in data.people)
            {
                lbxExample.Items.Add(person.Rank + " " + person.Name + " " + person.Birthday.ToShortDateString());
            }

            lbxRtxt.Items.Add("Hiện tại mới biết:");
            lbxRtxt.Items.Add("RichTextBox thuần ( chỉ có các hàm hỗ trợ ) thì chỉ Write đc ra Txt và Rtf File");
            lbxRtxt.Items.Add("RichTextBox có sử dụng các Namespace đặc biệt thì có thể Write đc ra các File khác");

            lbxFile.Items.Add("Write - Read File có 3 bước chính:");
            lbxFile.Items.Add("B1: Tạo ra 1 đối tượng để đọc hoặc ghi File vào ( StreamReader, StreamWriter, StreamFile, Document ( DocX, iTextSharpe ), DocumentCore ( SautinSorf )");
            lbxFile.Items.Add("B2: Lưu File vào 1 đường link trong máy tính vs 1 định dạng File cụ thể: Do SaveFileDialog và OpenFileDialog");
            lbxFile.Items.Add("\t+Lưu File vào 1 đường link trong máy tính: Có 3 cách t dùng:");
            lbxFile.Items.Add("\t\t1. Sử dụng SaveFileDialog.FileName và OpenFileDialog.FileName: Trả về Full link ( nghĩa có cả path của Folder, cả tên và định dạng đuôi của File )");
            lbxFile.Items.Add("\t\t2. Sử dụng FolderBrowser.SelectedPath: Trả về path của Folder chưa có tên File và định dạng của chúng");
            lbxFile.Items.Add("\t\t3. Sử dụng đối tượng System.IO.Path: path = new System.IO.Path( )");
            lbxFile.Items.Add("\t\t\t3.1: path.GetDirectoryPath( tên File ): Trả về như FolderBrowser.SelectedPath");
            lbxFile.Items.Add("\t\t\t3.2: path.GetFullDirectoryPath( tên File ): Trả về như SaveFileDialog.FileName");
            lbxFile.Items.Add("\t+Lưu File dưới định dạng đuôi tương ứng của từng kiểu File");

            lbxFile.Items.Add("");
            lbxFile.Items.Add("Các Namespace hỗ trợ:");
            lbxFile.Items.Add("\t+Add Reference Microsoft Word 16.0 Object Library và Microsoft Excel 16.0 Object Library:");
            lbxFile.Items.Add("\t\tusing Microsorf.Office.Interope.Word: Hỗ trợ Word");
            lbxFile.Items.Add("\t\tusing Microsoft.Office.Interope.Excel: Hỗ trợ Excel");
            lbxFile.Items.Add("\t+NuGet Packet Manager DocX: using Xceed.Word.Net: Hỗ trợ Word");
            lbxFile.Items.Add("\t+NuGet Packet Manager iTextSharp: using iTextSharp.text.Pdf: Hỗ trợ Pdf");
            lbxFile.Items.Add("\t+NuGet Packet Manager SautinSorf: using SautinSorf.Document: Hỗ trợ tất");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 2)
            {
                lbxExample.Visible = false;
                txtExample.Visible = false;
                dtExample.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }
        }

        /// <summary>
        /// pageRichTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWriteTxt_Click(object sender, EventArgs e)
        {
            // Định dạng đuôi
            save.Filter = "File TXT|*.txt";
            // Vì RichTextBox có hỗ trợ File nên không cần phải sử dụng bất cứ 1 obj nào để ghi File
            // Còn nếu vẫn muốn sử dung obj để ghi thì cũng đc
            if (save.ShowDialog() == DialogResult.OK)
            {
                rtxtExample.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                //rtxtExample.SaveFile(save.FileName, RichTextBoxStreamType.RichNoOleObjs);
                //rtxtExample.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
                //rtxtExample.SaveFile(save.FileName, RichTextBoxStreamType.TextTextOleObjs);
                //rtxtExample.SaveFile(save.FileName, RichTextBoxStreamType.UnicodePlainText);
                MessageBox.Show("Done");
            }
        }

        private void btnReadTxt_Click(object sender, EventArgs e)
        {
            // Định dạng đuôi
            open.Filter = "File TXT|*.txt";
            // Mở File thì luôn phải dùng 1 obj để mở và dễ cũng như tiện nhất đó là openFileDialog 
            // Ngoài ra có thể sử dụng FolderBrowser hoặc chỉ định đường dẫn cụ thể bằng class Path
            if (open.ShowDialog() == DialogResult.OK)
            {
                Stream stream = open.OpenFile();
                // Tạo 1 obj để đọc 
                StreamReader read = new StreamReader(stream);
                rtxtExample.Text = read.ReadToEnd();
                read.Close();
            }
        }

        private void btnWriteRtf_Click(object sender, EventArgs e)
        {
            // Tượng tự trên
            save.Filter = "File Rtf| *.rtf";
            if (save.ShowDialog() == DialogResult.OK)
            {
                rtxtExample.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                //rtxtExample.SaveFile(save.FileName, RichTextBoxStreamType.RichNoOleObjs);
                //rtxtExample.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
                //rtxtExample.SaveFile(save.FileName, RichTextBoxStreamType.TextTextOleObjs);
                //rtxtExample.SaveFile(save.FileName, RichTextBoxStreamType.UnicodePlainText);
                MessageBox.Show("Done");
            }
        }

        private void btnReadRtf_Click(object sender, EventArgs e)
        {
            // Tương tự
            open.Filter = "File Rtf| *.rtf";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Stream stream = open.OpenFile();
                StreamReader read = new StreamReader(stream);
                rtxtExample.Text = read.ReadToEnd();
                read.Close();
            }
        }

        /// <summary>
        /// pageAllFile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (rbtnTxt.Checked == true)
            {
                #region System: using System.IO
                save.Filter = "File TXT| *.txt";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // save.FileName: Tên File vs định dạng đuôi do save.Filter quy định
                        // true or false: Cho phép ghi tiếp File đã tồn tại (true) hay là ghi đè (false)
                        // Encoding.UTF8: Các ký tự đặc biết như có dấu hoặc ê, â...
                        StreamWriter write = new /*System.IO.*/StreamWriter(save.FileName, true, Encoding.UTF8);
                        foreach (var item in lbxExample.Items)
                        {
                            string line = item.ToString();
                            write.WriteLine(line);
                        }
                        write.WriteLine(rtxtExample.Text);
                        write.WriteLine(txtExample.Text);
                        write.WriteLine(dtExample.Value);

                        write.Close();
                        MessageBox.Show("Done");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                #endregion
            }
            else if (rbtnRtf.Checked == true)
            {
                #region Sautinsoft: using Sautinsoft.Document
                save.Filter = "File RTF| *.rtf";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DocumentCore document = new DocumentCore();
                        // Tao 1 char dac biet LineBreak == '\n';
                        // Ngoai ra con co nhiu char khac nhu tab...
                        SpecialCharacter spec = new SpecialCharacter(document, SpecialCharacterType.LineBreak);
                        // Cach 1:
                        document.Content.End.Insert(rtxtExample.Text + spec.Content);
                        foreach (var item in lbxExample.Items)
                        {
                            document.Content.End.Insert(item + "\n");
                        }
                        document.Content.End.Insert(txtExample.Text + "\n" + dtExample.Value);
                        document.Save(save.FileName);
                        MessageBox.Show("Done");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                #endregion
            }
            else if (rbtnDocx.Checked == true)
            {
                save.Filter = "File DOCX| *.docx";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        #region Microsoft Word 16.0 Object Library: using Microsoft.Office.Interop.Word;

                        Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();
                        Microsoft.Office.Interop.Word.Document document = new Microsoft.Office.Interop.Word.Document();
                        application.Visible = true;
                        object obj = System.Reflection.Missing.Value;
                        document = application.Documents.Add(ref obj);
                        application.Selection.TypeText(rtxtExample.Text);
                        foreach (var item in lbxExample.Items)
                        {
                            application.Selection.TypeText(item.ToString() + "\n");
                        }
                        application.Selection.TypeText(txtExample.Text + "\n" + dtExample.Value);
                        application = null;

                        #endregion



                        #region Sautinsoft: using Sautinsoft.Document

                        //DocumentCore document = new DocumentCore();
                        //// Tao 1 char dac biet LineBreak == '\n';
                        //// Ngoai ra con co nhiu char khac nhu tab...
                        //SpecialCharacter spec = new SpecialCharacter(document, SpecialCharacterType.LineBreak);
                        //// Cach 1:
                        //document.Content.End.Insert(rtxtExample.Text + spec.Content);
                        //foreach (var item in lbxExample.Items)
                        //{
                        //    document.Content.End.Insert(item + "\n");
                        //}
                        //document.Content.End.Insert(txtExample.Text + "\n" + dtExample.Value);
                        //document.Save(save.FileName);

                        #endregion




                        #region DocX: using Xceed.Words.NET

                        //var doc = DocX.Create(save.FileName);
                        //doc.InsertParagraph(rtxtExample.Text + "\n");
                        //foreach (var item in lbxExample.Items)
                        //{
                        //    doc.InsertParagraph(item + "\n");
                        //}
                        //doc.InsertParagraph(txtExample.Text + "\n" + dtExample.Value);
                        //doc.Save();

                        #endregion

                        MessageBox.Show("Done");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (rbtnPdf.Checked == true)
            {
                save.Filter = "File PDF| *.pdf";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        #region iTextSharp: using iTextSharp.text.pdf

                        iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate());
                        PdfWriter.GetInstance(document, new FileStream(save.FileName, FileMode.Create));
                        document.Open();
                        document.Add(new iTextSharp.text.Paragraph(rtxtExample.Text));
                        foreach (var item in lbxExample.Items)
                        {
                            document.Add(new iTextSharp.text.Paragraph(item.ToString()));
                        }
                        document.Add(new iTextSharp.text.Paragraph(txtExample.Text + "\n" + dtExample.Value));
                        document.Close();

                        #endregion

                        MessageBox.Show("Done");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else if (rbtnExcel.Checked == true)
            {

            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (rbtnTxt.Checked == true)
            {
                open.Filter = "File TXT| *.txt";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (System.IO.File.Exists(open.FileName))
                        {
                            StreamReader read = new StreamReader(open.FileName, Encoding.UTF8);
                            string line = read.ReadLine();
                            while (line != null)
                            {
                                string[] arrString = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                if (arrString.Length == 3)
                                {
                                    rtxtExample.Text += arrString[0] + "\t" + arrString[1] + "\t" + arrString[2] + "\n";
                                }
                                line = read.ReadLine();
                            }
                            read.Close();
                            MessageBox.Show("Done");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (rbtnRtf.Checked == true)
            {

            }
            else if (rbtnDocx.Checked == true)
            {

            }
            else if (rbtnPdf.Checked == true)
            {

            }
            else if (rbtnExcel.Checked == true)
            {

            }
        }
    }
}
