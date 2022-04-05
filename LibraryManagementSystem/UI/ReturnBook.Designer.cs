
namespace LibraryManagementSystem.UI
{
    partial class ReturnBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BookL = new System.Windows.Forms.Label();
            this.MemberL = new System.Windows.Forms.Label();
            this.BookTB = new System.Windows.Forms.TextBox();
            this.MemberTB = new System.Windows.Forms.TextBox();
            this.MemberAndBookRB = new System.Windows.Forms.RadioButton();
            this.BookRB = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.MemberRB = new System.Windows.Forms.RadioButton();
            this.NoneRB = new System.Windows.Forms.RadioButton();
            this.IssueDetails = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.ReIssueBtn = new System.Windows.Forms.Button();
            this.IssuedOnDTP = new System.Windows.Forms.DateTimePicker();
            this.ReturnDTP = new System.Windows.Forms.DateTimePicker();
            this.Result = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CommentsTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IssuedByTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MemberTBR = new System.Windows.Forms.TextBox();
            this.BookTBR = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IssueDetails)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CloseBox);
            this.panel1.Controls.Add(this.header);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 65);
            this.panel1.TabIndex = 1;
            // 
            // CloseBox
            // 
            this.CloseBox.Image = global::LibraryManagementSystem.Properties.Resources.exit;
            this.CloseBox.InitialImage = global::LibraryManagementSystem.Properties.Resources.exit;
            this.CloseBox.Location = new System.Drawing.Point(1212, 19);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(28, 26);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBox.TabIndex = 2;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(460, 13);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(346, 37);
            this.header.TabIndex = 1;
            this.header.Text = "Return/Re-issue Book";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.BookL);
            this.panel2.Controls.Add(this.MemberL);
            this.panel2.Controls.Add(this.BookTB);
            this.panel2.Controls.Add(this.MemberTB);
            this.panel2.Controls.Add(this.MemberAndBookRB);
            this.panel2.Controls.Add(this.BookRB);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.MemberRB);
            this.panel2.Controls.Add(this.NoneRB);
            this.panel2.Location = new System.Drawing.Point(13, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1239, 49);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1136, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "FIND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookL
            // 
            this.BookL.AutoSize = true;
            this.BookL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookL.Location = new System.Drawing.Point(883, 14);
            this.BookL.Name = "BookL";
            this.BookL.Size = new System.Drawing.Size(52, 18);
            this.BookL.TabIndex = 24;
            this.BookL.Text = "BOOK";
            this.BookL.Visible = false;
            // 
            // MemberL
            // 
            this.MemberL.AutoSize = true;
            this.MemberL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberL.Location = new System.Drawing.Point(627, 14);
            this.MemberL.Name = "MemberL";
            this.MemberL.Size = new System.Drawing.Size(75, 18);
            this.MemberL.TabIndex = 23;
            this.MemberL.Text = "MEMBER";
            this.MemberL.Visible = false;
            // 
            // BookTB
            // 
            this.BookTB.Location = new System.Drawing.Point(978, 14);
            this.BookTB.Name = "BookTB";
            this.BookTB.Size = new System.Drawing.Size(112, 20);
            this.BookTB.TabIndex = 22;
            this.BookTB.Visible = false;
            this.BookTB.TextChanged += new System.EventHandler(this.BookTB_TextChanged);
            // 
            // MemberTB
            // 
            this.MemberTB.Location = new System.Drawing.Point(733, 15);
            this.MemberTB.Name = "MemberTB";
            this.MemberTB.Size = new System.Drawing.Size(112, 20);
            this.MemberTB.TabIndex = 21;
            this.MemberTB.Visible = false;
            this.MemberTB.TextChanged += new System.EventHandler(this.MemberTB_TextChanged);
            // 
            // MemberAndBookRB
            // 
            this.MemberAndBookRB.AutoSize = true;
            this.MemberAndBookRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberAndBookRB.Location = new System.Drawing.Point(446, 14);
            this.MemberAndBookRB.Name = "MemberAndBookRB";
            this.MemberAndBookRB.Size = new System.Drawing.Size(141, 21);
            this.MemberAndBookRB.TabIndex = 20;
            this.MemberAndBookRB.Text = "Member and Book";
            this.MemberAndBookRB.UseVisualStyleBackColor = true;
            this.MemberAndBookRB.CheckedChanged += new System.EventHandler(this.MemberAndBookRB_CheckedChanged);
            // 
            // BookRB
            // 
            this.BookRB.AutoSize = true;
            this.BookRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookRB.Location = new System.Drawing.Point(351, 14);
            this.BookRB.Name = "BookRB";
            this.BookRB.Size = new System.Drawing.Size(58, 21);
            this.BookRB.TabIndex = 19;
            this.BookRB.Text = "Book";
            this.BookRB.UseVisualStyleBackColor = true;
            this.BookRB.CheckedChanged += new System.EventHandler(this.BookRB_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "FIND BY";
            // 
            // MemberRB
            // 
            this.MemberRB.AutoSize = true;
            this.MemberRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberRB.Location = new System.Drawing.Point(237, 14);
            this.MemberRB.Name = "MemberRB";
            this.MemberRB.Size = new System.Drawing.Size(77, 21);
            this.MemberRB.TabIndex = 17;
            this.MemberRB.Text = "Member";
            this.MemberRB.UseVisualStyleBackColor = true;
            this.MemberRB.CheckedChanged += new System.EventHandler(this.MemberRB_CheckedChanged);
            // 
            // NoneRB
            // 
            this.NoneRB.AutoSize = true;
            this.NoneRB.Checked = true;
            this.NoneRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoneRB.Location = new System.Drawing.Point(130, 14);
            this.NoneRB.Name = "NoneRB";
            this.NoneRB.Size = new System.Drawing.Size(60, 21);
            this.NoneRB.TabIndex = 16;
            this.NoneRB.TabStop = true;
            this.NoneRB.Text = "None";
            this.NoneRB.UseVisualStyleBackColor = true;
            this.NoneRB.CheckedChanged += new System.EventHandler(this.NoneRB_CheckedChanged);
            // 
            // IssueDetails
            // 
            this.IssueDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IssueDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.IssueDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IssueDetails.DefaultCellStyle = dataGridViewCellStyle4;
            this.IssueDetails.Location = new System.Drawing.Point(13, 139);
            this.IssueDetails.Name = "IssueDetails";
            this.IssueDetails.ReadOnly = true;
            this.IssueDetails.Size = new System.Drawing.Size(1241, 295);
            this.IssueDetails.TabIndex = 3;
            this.IssueDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDetails_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CancelBtn);
            this.panel3.Controls.Add(this.ReturnBtn);
            this.panel3.Controls.Add(this.ReIssueBtn);
            this.panel3.Controls.Add(this.IssuedOnDTP);
            this.panel3.Controls.Add(this.ReturnDTP);
            this.panel3.Controls.Add(this.Result);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.CommentsTB);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.IssuedByTB);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.MemberTBR);
            this.panel3.Controls.Add(this.BookTBR);
            this.panel3.Location = new System.Drawing.Point(12, 441);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1242, 196);
            this.panel3.TabIndex = 4;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(684, 147);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 50;
            this.CancelBtn.Text = "CANCEL";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(588, 147);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(75, 23);
            this.ReturnBtn.TabIndex = 49;
            this.ReturnBtn.Text = "RETURN";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // ReIssueBtn
            // 
            this.ReIssueBtn.Location = new System.Drawing.Point(494, 147);
            this.ReIssueBtn.Name = "ReIssueBtn";
            this.ReIssueBtn.Size = new System.Drawing.Size(75, 23);
            this.ReIssueBtn.TabIndex = 48;
            this.ReIssueBtn.Text = "RE-ISSUE";
            this.ReIssueBtn.UseVisualStyleBackColor = true;
            this.ReIssueBtn.Click += new System.EventHandler(this.ReIssueBtn_Click);
            // 
            // IssuedOnDTP
            // 
            this.IssuedOnDTP.Enabled = false;
            this.IssuedOnDTP.Location = new System.Drawing.Point(131, 74);
            this.IssuedOnDTP.Name = "IssuedOnDTP";
            this.IssuedOnDTP.Size = new System.Drawing.Size(200, 20);
            this.IssuedOnDTP.TabIndex = 47;
            // 
            // ReturnDTP
            // 
            this.ReturnDTP.Enabled = false;
            this.ReturnDTP.Location = new System.Drawing.Point(577, 74);
            this.ReturnDTP.Name = "ReturnDTP";
            this.ReturnDTP.Size = new System.Drawing.Size(200, 20);
            this.ReturnDTP.TabIndex = 46;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.Crimson;
            this.Result.Location = new System.Drawing.Point(18, 124);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 18);
            this.Result.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(899, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "COMMENTS";
            // 
            // CommentsTB
            // 
            this.CommentsTB.BackColor = System.Drawing.SystemColors.Window;
            this.CommentsTB.Location = new System.Drawing.Point(1012, 75);
            this.CommentsTB.Name = "CommentsTB";
            this.CommentsTB.ReadOnly = true;
            this.CommentsTB.Size = new System.Drawing.Size(200, 20);
            this.CommentsTB.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(899, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "ISSUED BY";
            // 
            // IssuedByTB
            // 
            this.IssuedByTB.BackColor = System.Drawing.SystemColors.Window;
            this.IssuedByTB.Location = new System.Drawing.Point(1012, 24);
            this.IssuedByTB.Name = "IssuedByTB";
            this.IssuedByTB.ReadOnly = true;
            this.IssuedByTB.Size = new System.Drawing.Size(200, 20);
            this.IssuedByTB.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "RETURN BY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(464, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "MEMBER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "BOOK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "ISSUED ON";
            // 
            // MemberTBR
            // 
            this.MemberTBR.Location = new System.Drawing.Point(577, 24);
            this.MemberTBR.Name = "MemberTBR";
            this.MemberTBR.Size = new System.Drawing.Size(200, 20);
            this.MemberTBR.TabIndex = 36;
            this.MemberTBR.TextChanged += new System.EventHandler(this.MemberTBR_TextChanged);
            // 
            // BookTBR
            // 
            this.BookTBR.Location = new System.Drawing.Point(131, 25);
            this.BookTBR.Name = "BookTBR";
            this.BookTBR.Size = new System.Drawing.Size(200, 20);
            this.BookTBR.TabIndex = 35;
            this.BookTBR.TextChanged += new System.EventHandler(this.BookTBR_TextChanged);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 649);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.IssueDetails);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IssueDetails)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton MemberAndBookRB;
        private System.Windows.Forms.RadioButton BookRB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton MemberRB;
        private System.Windows.Forms.RadioButton NoneRB;
        private System.Windows.Forms.Label BookL;
        private System.Windows.Forms.Label MemberL;
        private System.Windows.Forms.TextBox BookTB;
        private System.Windows.Forms.TextBox MemberTB;
        private System.Windows.Forms.DataGridView IssueDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker IssuedOnDTP;
        private System.Windows.Forms.DateTimePicker ReturnDTP;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CommentsTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IssuedByTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MemberTBR;
        private System.Windows.Forms.TextBox BookTBR;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button ReIssueBtn;
        private System.Windows.Forms.Button button1;
    }
}