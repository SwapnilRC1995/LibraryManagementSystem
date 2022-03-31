
namespace LibraryManagementSystem.UI
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEMBERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iSSUEBOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rETURNBOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.User = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOOKToolStripMenuItem,
            this.mEMBERToolStripMenuItem,
            this.iSSUEBOOKToolStripMenuItem,
            this.rETURNBOOKToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1120, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bOOKToolStripMenuItem
            // 
            this.bOOKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.viewBooksToolStripMenuItem});
            this.bOOKToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOOKToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.books;
            this.bOOKToolStripMenuItem.Name = "bOOKToolStripMenuItem";
            this.bOOKToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.bOOKToolStripMenuItem.Size = new System.Drawing.Size(113, 32);
            this.bOOKToolStripMenuItem.Text = "BOOK";
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.plus;
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(221, 32);
            this.addNewBookToolStripMenuItem.Text = "Add new book";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // viewBooksToolStripMenuItem
            // 
            this.viewBooksToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.eye;
            this.viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            this.viewBooksToolStripMenuItem.Size = new System.Drawing.Size(221, 32);
            this.viewBooksToolStripMenuItem.Text = "View books";
            this.viewBooksToolStripMenuItem.Click += new System.EventHandler(this.viewBooksToolStripMenuItem_Click);
            // 
            // mEMBERToolStripMenuItem
            // 
            this.mEMBERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewMemberToolStripMenuItem,
            this.viewMembersToolStripMenuItem});
            this.mEMBERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mEMBERToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.member;
            this.mEMBERToolStripMenuItem.Name = "mEMBERToolStripMenuItem";
            this.mEMBERToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.mEMBERToolStripMenuItem.Size = new System.Drawing.Size(139, 32);
            this.mEMBERToolStripMenuItem.Text = "MEMBER";
            // 
            // addNewMemberToolStripMenuItem
            // 
            this.addNewMemberToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.plus;
            this.addNewMemberToolStripMenuItem.Name = "addNewMemberToolStripMenuItem";
            this.addNewMemberToolStripMenuItem.Size = new System.Drawing.Size(239, 32);
            this.addNewMemberToolStripMenuItem.Text = "Add new member";
            this.addNewMemberToolStripMenuItem.Click += new System.EventHandler(this.addNewMemberToolStripMenuItem_Click);
            // 
            // viewMembersToolStripMenuItem
            // 
            this.viewMembersToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.eye;
            this.viewMembersToolStripMenuItem.Name = "viewMembersToolStripMenuItem";
            this.viewMembersToolStripMenuItem.Size = new System.Drawing.Size(239, 32);
            this.viewMembersToolStripMenuItem.Text = "View members";
            // 
            // iSSUEBOOKToolStripMenuItem
            // 
            this.iSSUEBOOKToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iSSUEBOOKToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.issue_book;
            this.iSSUEBOOKToolStripMenuItem.Name = "iSSUEBOOKToolStripMenuItem";
            this.iSSUEBOOKToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.iSSUEBOOKToolStripMenuItem.Size = new System.Drawing.Size(169, 32);
            this.iSSUEBOOKToolStripMenuItem.Text = "ISSUE BOOK";
            this.iSSUEBOOKToolStripMenuItem.Click += new System.EventHandler(this.iSSUEBOOKToolStripMenuItem_Click);
            // 
            // rETURNBOOKToolStripMenuItem
            // 
            this.rETURNBOOKToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rETURNBOOKToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.return_book;
            this.rETURNBOOKToolStripMenuItem.Name = "rETURNBOOKToolStripMenuItem";
            this.rETURNBOOKToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.rETURNBOOKToolStripMenuItem.Size = new System.Drawing.Size(191, 32);
            this.rETURNBOOKToolStripMenuItem.Text = "RETURN BOOK";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eXITToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.exit;
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(86, 32);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // User
            // 
            this.User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.User.AutoSize = true;
            this.User.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(929, 9);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(112, 17);
            this.User.TabIndex = 2;
            this.User.Text = "Logged in as: ";
            this.User.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1120, 450);
            this.Controls.Add(this.User);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem bOOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEMBERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iSSUEBOOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rETURNBOOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label User;
    }
}