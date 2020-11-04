namespace Unit3_DataGridView
{
    partial class frmBasic
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
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.txbMa = new System.Windows.Forms.TextBox();
            this.dataGVDisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // txbSDT
            // 
            this.txbSDT.Location = new System.Drawing.Point(12, 264);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(100, 20);
            this.txbSDT.TabIndex = 10;
            this.txbSDT.Click += new System.EventHandler(this.dataGVDisplay_Click);
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(12, 235);
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(100, 20);
            this.txbTen.TabIndex = 9;
            this.txbTen.Click += new System.EventHandler(this.dataGVDisplay_Click);
            // 
            // txbMa
            // 
            this.txbMa.Location = new System.Drawing.Point(12, 206);
            this.txbMa.Name = "txbMa";
            this.txbMa.Size = new System.Drawing.Size(100, 20);
            this.txbMa.TabIndex = 8;
            this.txbMa.Click += new System.EventHandler(this.dataGVDisplay_Click);
            // 
            // dataGVDisplay
            // 
            this.dataGVDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGVDisplay.Location = new System.Drawing.Point(0, 0);
            this.dataGVDisplay.Name = "dataGVDisplay";
            this.dataGVDisplay.Size = new System.Drawing.Size(287, 197);
            this.dataGVDisplay.TabIndex = 7;
            this.dataGVDisplay.Click += new System.EventHandler(this.dataGVDisplay_Click);
            // 
            // frmBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 286);
            this.Controls.Add(this.txbSDT);
            this.Controls.Add(this.txbTen);
            this.Controls.Add(this.txbMa);
            this.Controls.Add(this.dataGVDisplay);
            this.Name = "frmBasic";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.TextBox txbMa;
        private System.Windows.Forms.DataGridView dataGVDisplay;
    }
}

