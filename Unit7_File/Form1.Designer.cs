namespace Unit7_File
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbtnTxt = new System.Windows.Forms.RadioButton();
            this.rbtnRtf = new System.Windows.Forms.RadioButton();
            this.rbtnDocx = new System.Windows.Forms.RadioButton();
            this.rbtnPdf = new System.Windows.Forms.RadioButton();
            this.rbtnExcel = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReadRtf = new System.Windows.Forms.Button();
            this.btnReadTxt = new System.Windows.Forms.Button();
            this.btnWriteRtf = new System.Windows.Forms.Button();
            this.btnWriteTxt = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxFile = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxRtxt = new System.Windows.Forms.ListBox();
            this.dtExample = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExample = new System.Windows.Forms.TextBox();
            this.lbxExample = new System.Windows.Forms.ListBox();
            this.rtxtExample = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtExample);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txtExample);
            this.splitContainer1.Panel2.Controls.Add(this.lbxExample);
            this.splitContainer1.Panel2.Controls.Add(this.rtxtExample);
            this.splitContainer1.Size = new System.Drawing.Size(657, 409);
            this.splitContainer1.SplitterDistance = 315;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage7);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(315, 409);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btnRead);
            this.tabPage7.Controls.Add(this.btnWrite);
            this.tabPage7.Controls.Add(this.flowLayoutPanel1);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(307, 383);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Text File";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(8, 227);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(125, 34);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(8, 171);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(125, 34);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rbtnTxt);
            this.flowLayoutPanel1.Controls.Add(this.rbtnRtf);
            this.flowLayoutPanel1.Controls.Add(this.rbtnDocx);
            this.flowLayoutPanel1.Controls.Add(this.rbtnPdf);
            this.flowLayoutPanel1.Controls.Add(this.rbtnExcel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(301, 152);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // rbtnTxt
            // 
            this.rbtnTxt.AutoSize = true;
            this.rbtnTxt.Location = new System.Drawing.Point(3, 3);
            this.rbtnTxt.Name = "rbtnTxt";
            this.rbtnTxt.Size = new System.Drawing.Size(46, 17);
            this.rbtnTxt.TabIndex = 0;
            this.rbtnTxt.TabStop = true;
            this.rbtnTxt.Text = "TXT";
            this.rbtnTxt.UseVisualStyleBackColor = true;
            // 
            // rbtnRtf
            // 
            this.rbtnRtf.AutoSize = true;
            this.rbtnRtf.Location = new System.Drawing.Point(3, 26);
            this.rbtnRtf.Name = "rbtnRtf";
            this.rbtnRtf.Size = new System.Drawing.Size(46, 17);
            this.rbtnRtf.TabIndex = 1;
            this.rbtnRtf.TabStop = true;
            this.rbtnRtf.Text = "RTF";
            this.rbtnRtf.UseVisualStyleBackColor = true;
            // 
            // rbtnDocx
            // 
            this.rbtnDocx.AutoSize = true;
            this.rbtnDocx.Location = new System.Drawing.Point(3, 49);
            this.rbtnDocx.Name = "rbtnDocx";
            this.rbtnDocx.Size = new System.Drawing.Size(55, 17);
            this.rbtnDocx.TabIndex = 3;
            this.rbtnDocx.TabStop = true;
            this.rbtnDocx.Text = "DOCX";
            this.rbtnDocx.UseVisualStyleBackColor = true;
            // 
            // rbtnPdf
            // 
            this.rbtnPdf.AutoSize = true;
            this.rbtnPdf.Location = new System.Drawing.Point(3, 72);
            this.rbtnPdf.Name = "rbtnPdf";
            this.rbtnPdf.Size = new System.Drawing.Size(46, 17);
            this.rbtnPdf.TabIndex = 2;
            this.rbtnPdf.TabStop = true;
            this.rbtnPdf.Text = "PDF";
            this.rbtnPdf.UseVisualStyleBackColor = true;
            // 
            // rbtnExcel
            // 
            this.rbtnExcel.AutoSize = true;
            this.rbtnExcel.Location = new System.Drawing.Point(3, 95);
            this.rbtnExcel.Name = "rbtnExcel";
            this.rbtnExcel.Size = new System.Drawing.Size(51, 17);
            this.rbtnExcel.TabIndex = 4;
            this.rbtnExcel.TabStop = true;
            this.rbtnExcel.Text = "Excel";
            this.rbtnExcel.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(353, 383);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "Serialization File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReadRtf);
            this.tabPage2.Controls.Add(this.btnReadTxt);
            this.tabPage2.Controls.Add(this.btnWriteRtf);
            this.tabPage2.Controls.Add(this.btnWriteTxt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(353, 383);
            this.tabPage2.TabIndex = 8;
            this.tabPage2.Text = "RichTextBox";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnReadRtf
            // 
            this.btnReadRtf.Location = new System.Drawing.Point(202, 95);
            this.btnReadRtf.Name = "btnReadRtf";
            this.btnReadRtf.Size = new System.Drawing.Size(114, 43);
            this.btnReadRtf.TabIndex = 3;
            this.btnReadRtf.Text = "Read Rtf";
            this.btnReadRtf.UseVisualStyleBackColor = true;
            this.btnReadRtf.Click += new System.EventHandler(this.btnReadRtf_Click);
            // 
            // btnReadTxt
            // 
            this.btnReadTxt.Location = new System.Drawing.Point(25, 95);
            this.btnReadTxt.Name = "btnReadTxt";
            this.btnReadTxt.Size = new System.Drawing.Size(114, 43);
            this.btnReadTxt.TabIndex = 2;
            this.btnReadTxt.Text = "Read Txt";
            this.btnReadTxt.UseVisualStyleBackColor = true;
            this.btnReadTxt.Click += new System.EventHandler(this.btnReadTxt_Click);
            // 
            // btnWriteRtf
            // 
            this.btnWriteRtf.Location = new System.Drawing.Point(202, 26);
            this.btnWriteRtf.Name = "btnWriteRtf";
            this.btnWriteRtf.Size = new System.Drawing.Size(114, 43);
            this.btnWriteRtf.TabIndex = 1;
            this.btnWriteRtf.Text = "Write Rtf";
            this.btnWriteRtf.UseVisualStyleBackColor = true;
            this.btnWriteRtf.Click += new System.EventHandler(this.btnWriteRtf_Click);
            // 
            // btnWriteTxt
            // 
            this.btnWriteTxt.Location = new System.Drawing.Point(25, 26);
            this.btnWriteTxt.Name = "btnWriteTxt";
            this.btnWriteTxt.Size = new System.Drawing.Size(114, 43);
            this.btnWriteTxt.TabIndex = 0;
            this.btnWriteTxt.Text = "Write Txt";
            this.btnWriteTxt.UseVisualStyleBackColor = true;
            this.btnWriteTxt.Click += new System.EventHandler(this.btnWriteTxt_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(221, 383);
            this.tabPage3.TabIndex = 9;
            this.tabPage3.Text = "Notice";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxFile);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 277);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File";
            // 
            // lbxFile
            // 
            this.lbxFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxFile.FormattingEnabled = true;
            this.lbxFile.Location = new System.Drawing.Point(3, 16);
            this.lbxFile.Name = "lbxFile";
            this.lbxFile.Size = new System.Drawing.Size(209, 258);
            this.lbxFile.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxRtxt);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RichTextBox";
            // 
            // lbxRtxt
            // 
            this.lbxRtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxRtxt.FormattingEnabled = true;
            this.lbxRtxt.Location = new System.Drawing.Point(3, 16);
            this.lbxRtxt.Name = "lbxRtxt";
            this.lbxRtxt.Size = new System.Drawing.Size(209, 81);
            this.lbxRtxt.TabIndex = 0;
            // 
            // dtExample
            // 
            this.dtExample.CustomFormat = "dd/MM/yyyy";
            this.dtExample.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtExample.Location = new System.Drawing.Point(100, 354);
            this.dtExample.Name = "dtExample";
            this.dtExample.Size = new System.Drawing.Size(164, 20);
            this.dtExample.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Name";
            // 
            // txtExample
            // 
            this.txtExample.Location = new System.Drawing.Point(100, 318);
            this.txtExample.Name = "txtExample";
            this.txtExample.Size = new System.Drawing.Size(164, 20);
            this.txtExample.TabIndex = 20;
            // 
            // lbxExample
            // 
            this.lbxExample.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbxExample.FormattingEnabled = true;
            this.lbxExample.Location = new System.Drawing.Point(0, 180);
            this.lbxExample.Name = "lbxExample";
            this.lbxExample.Size = new System.Drawing.Size(334, 121);
            this.lbxExample.TabIndex = 19;
            // 
            // rtxtExample
            // 
            this.rtxtExample.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtxtExample.Location = new System.Drawing.Point(0, 0);
            this.rtxtExample.Name = "rtxtExample";
            this.rtxtExample.Size = new System.Drawing.Size(334, 180);
            this.rtxtExample.TabIndex = 18;
            this.rtxtExample.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 409);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAllFile_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rbtnTxt;
        private System.Windows.Forms.RadioButton rbtnRtf;
        private System.Windows.Forms.RadioButton rbtnDocx;
        private System.Windows.Forms.RadioButton rbtnPdf;
        private System.Windows.Forms.RadioButton rbtnExcel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnReadRtf;
        private System.Windows.Forms.Button btnReadTxt;
        private System.Windows.Forms.Button btnWriteRtf;
        private System.Windows.Forms.Button btnWriteTxt;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbxFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxRtxt;
        private System.Windows.Forms.DateTimePicker dtExample;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExample;
        private System.Windows.Forms.ListBox lbxExample;
        private System.Windows.Forms.RichTextBox rtxtExample;
    }
}

