
namespace LibraryManagementSystem.UI
{
    partial class IssueBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MemberTB = new System.Windows.Forms.TextBox();
            this.BookTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IssuedByTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CommentsTB = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.IssueBtn = new System.Windows.Forms.Button();
            this.ReturnDTP = new System.Windows.Forms.DateTimePicker();
            this.IssuedOnDTP = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.header);
            this.panel1.Location = new System.Drawing.Point(5, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 53);
            this.panel1.TabIndex = 1;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(226, 8);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(181, 37);
            this.header.TabIndex = 0;
            this.header.Text = "Issue book";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "MEMBER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "BOOK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "ISSUED ON";
            // 
            // MemberTB
            // 
            this.MemberTB.Location = new System.Drawing.Point(456, 104);
            this.MemberTB.Name = "MemberTB";
            this.MemberTB.Size = new System.Drawing.Size(200, 20);
            this.MemberTB.TabIndex = 16;
            this.MemberTB.TextChanged += new System.EventHandler(this.MemberTB_TextChanged);
            // 
            // BookTB
            // 
            this.BookTB.Location = new System.Drawing.Point(121, 104);
            this.BookTB.Name = "BookTB";
            this.BookTB.Size = new System.Drawing.Size(200, 20);
            this.BookTB.TabIndex = 15;
            this.BookTB.TextChanged += new System.EventHandler(this.BookTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "RETURN BY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "ISSUED BY";
            // 
            // IssuedByTB
            // 
            this.IssuedByTB.BackColor = System.Drawing.SystemColors.Window;
            this.IssuedByTB.Location = new System.Drawing.Point(121, 180);
            this.IssuedByTB.Name = "IssuedByTB";
            this.IssuedByTB.ReadOnly = true;
            this.IssuedByTB.Size = new System.Drawing.Size(200, 20);
            this.IssuedByTB.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "COMMENTS";
            // 
            // CommentsTB
            // 
            this.CommentsTB.BackColor = System.Drawing.SystemColors.Window;
            this.CommentsTB.Location = new System.Drawing.Point(456, 179);
            this.CommentsTB.Name = "CommentsTB";
            this.CommentsTB.ReadOnly = true;
            this.CommentsTB.Size = new System.Drawing.Size(200, 20);
            this.CommentsTB.TabIndex = 26;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.Crimson;
            this.Result.Location = new System.Drawing.Point(12, 221);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 18);
            this.Result.TabIndex = 31;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(389, 294);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 30;
            this.CancelBtn.Text = "CANCEL";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(293, 294);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 29;
            this.ResetBtn.Text = "RESET";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // IssueBtn
            // 
            this.IssueBtn.Location = new System.Drawing.Point(199, 294);
            this.IssueBtn.Name = "IssueBtn";
            this.IssueBtn.Size = new System.Drawing.Size(75, 23);
            this.IssueBtn.TabIndex = 28;
            this.IssueBtn.Text = "ISSUE";
            this.IssueBtn.UseVisualStyleBackColor = true;
            this.IssueBtn.Click += new System.EventHandler(this.IssueBtn_Click);
            // 
            // ReturnDTP
            // 
            this.ReturnDTP.Enabled = false;
            this.ReturnDTP.Location = new System.Drawing.Point(456, 141);
            this.ReturnDTP.Name = "ReturnDTP";
            this.ReturnDTP.Size = new System.Drawing.Size(200, 20);
            this.ReturnDTP.TabIndex = 33;
            // 
            // IssuedOnDTP
            // 
            this.IssuedOnDTP.Enabled = false;
            this.IssuedOnDTP.Location = new System.Drawing.Point(121, 141);
            this.IssuedOnDTP.Name = "IssuedOnDTP";
            this.IssuedOnDTP.Size = new System.Drawing.Size(200, 20);
            this.IssuedOnDTP.TabIndex = 34;
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 344);
            this.Controls.Add(this.IssuedOnDTP);
            this.Controls.Add(this.ReturnDTP);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.IssueBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CommentsTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IssuedByTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MemberTB);
            this.Controls.Add(this.BookTB);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueBook";
            this.Load += new System.EventHandler(this.IssueBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MemberTB;
        private System.Windows.Forms.TextBox BookTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IssuedByTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CommentsTB;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button IssueBtn;
        private System.Windows.Forms.DateTimePicker ReturnDTP;
        private System.Windows.Forms.DateTimePicker IssuedOnDTP;
    }
}