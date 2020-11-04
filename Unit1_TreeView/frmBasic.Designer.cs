namespace Unit1_TreeView
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
            this.components = new System.ComponentModel.Container();
            this.tvDisplay = new System.Windows.Forms.TreeView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.contextUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.expandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextExpnadEach = new System.Windows.Forms.ToolStripMenuItem();
            this.contextExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextCollapseEach = new System.Windows.Forms.ToolStripMenuItem();
            this.contextCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvDisplay
            // 
            this.tvDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDisplay.Location = new System.Drawing.Point(0, 0);
            this.tvDisplay.Name = "tvDisplay";
            this.tvDisplay.Size = new System.Drawing.Size(251, 418);
            this.tvDisplay.TabIndex = 2;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextAdd,
            this.contextUpdate,
            this.contextDel,
            this.toolStripMenuItem1,
            this.expandToolStripMenuItem,
            this.collapseToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 142);
            // 
            // contextAdd
            // 
            this.contextAdd.Name = "contextAdd";
            this.contextAdd.Size = new System.Drawing.Size(180, 22);
            this.contextAdd.Text = "Add";
            this.contextAdd.Click += new System.EventHandler(this.contextAdd_Click);
            // 
            // contextUpdate
            // 
            this.contextUpdate.Name = "contextUpdate";
            this.contextUpdate.Size = new System.Drawing.Size(180, 22);
            this.contextUpdate.Text = "Update";
            this.contextUpdate.Click += new System.EventHandler(this.contextUpdate_Click);
            // 
            // contextDel
            // 
            this.contextDel.Name = "contextDel";
            this.contextDel.Size = new System.Drawing.Size(180, 22);
            this.contextDel.Text = "Delete";
            this.contextDel.Click += new System.EventHandler(this.contextDel_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // expandToolStripMenuItem
            // 
            this.expandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextExpnadEach,
            this.contextExpandAll});
            this.expandToolStripMenuItem.Name = "expandToolStripMenuItem";
            this.expandToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.expandToolStripMenuItem.Text = "Expand";
            // 
            // contextExpnadEach
            // 
            this.contextExpnadEach.Name = "contextExpnadEach";
            this.contextExpnadEach.Size = new System.Drawing.Size(180, 22);
            this.contextExpnadEach.Text = "Expand Each";
            this.contextExpnadEach.Click += new System.EventHandler(this.contextExpnadEach_Click);
            // 
            // contextExpandAll
            // 
            this.contextExpandAll.Name = "contextExpandAll";
            this.contextExpandAll.Size = new System.Drawing.Size(180, 22);
            this.contextExpandAll.Text = "Expnad All";
            this.contextExpandAll.Click += new System.EventHandler(this.contextExpandAll_Click);
            // 
            // collapseToolStripMenuItem
            // 
            this.collapseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextCollapseEach,
            this.contextCollapseAll});
            this.collapseToolStripMenuItem.Name = "collapseToolStripMenuItem";
            this.collapseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.collapseToolStripMenuItem.Text = "Collapse";
            // 
            // contextCollapseEach
            // 
            this.contextCollapseEach.Name = "contextCollapseEach";
            this.contextCollapseEach.Size = new System.Drawing.Size(180, 22);
            this.contextCollapseEach.Text = "Collapse Each";
            this.contextCollapseEach.Click += new System.EventHandler(this.contextCollapseEach_Click);
            // 
            // contextCollapseAll
            // 
            this.contextCollapseAll.Name = "contextCollapseAll";
            this.contextCollapseAll.Size = new System.Drawing.Size(180, 22);
            this.contextCollapseAll.Text = "Collapse All";
            this.contextCollapseAll.Click += new System.EventHandler(this.contextCollapseAll_Click);
            // 
            // frmBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 418);
            this.Controls.Add(this.tvDisplay);
            this.Name = "frmBasic";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmBasic_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvDisplay;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem contextAdd;
        private System.Windows.Forms.ToolStripMenuItem contextUpdate;
        private System.Windows.Forms.ToolStripMenuItem contextDel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem expandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextExpnadEach;
        private System.Windows.Forms.ToolStripMenuItem contextExpandAll;
        private System.Windows.Forms.ToolStripMenuItem collapseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextCollapseEach;
        private System.Windows.Forms.ToolStripMenuItem contextCollapseAll;
    }
}

