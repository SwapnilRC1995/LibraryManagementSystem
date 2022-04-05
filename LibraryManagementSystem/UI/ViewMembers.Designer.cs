
namespace LibraryManagementSystem.UI
{
    partial class ViewMembers
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
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Label();
            this.MemberDetails = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.FineTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExpiryTB = new System.Windows.Forms.TextBox();
            this.ExtendMonth = new System.Windows.Forms.RadioButton();
            this.ExtendYear = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberDetails)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.CloseBox.TabIndex = 3;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(504, 14);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(253, 37);
            this.header.TabIndex = 1;
            this.header.Text = "Member Details";
            // 
            // MemberDetails
            // 
            this.MemberDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MemberDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MemberDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberDetails.Location = new System.Drawing.Point(12, 83);
            this.MemberDetails.Name = "MemberDetails";
            this.MemberDetails.ReadOnly = true;
            this.MemberDetails.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MemberDetails.Size = new System.Drawing.Size(1241, 295);
            this.MemberDetails.TabIndex = 2;
            this.MemberDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberDetails_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.FineTB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ExpiryTB);
            this.panel2.Controls.Add(this.ExtendMonth);
            this.panel2.Controls.Add(this.ExtendYear);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Result);
            this.panel2.Controls.Add(this.CancelBtn);
            this.panel2.Controls.Add(this.UpdateBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.NameTB);
            this.panel2.Location = new System.Drawing.Point(12, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1241, 146);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(650, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "FINE";
            // 
            // FineTB
            // 
            this.FineTB.BackColor = System.Drawing.SystemColors.Window;
            this.FineTB.Location = new System.Drawing.Point(712, 28);
            this.FineTB.Name = "FineTB";
            this.FineTB.Size = new System.Drawing.Size(172, 20);
            this.FineTB.TabIndex = 36;
            this.FineTB.TextChanged += new System.EventHandler(this.FineTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "EXPIRY DATE";
            // 
            // ExpiryTB
            // 
            this.ExpiryTB.BackColor = System.Drawing.SystemColors.Window;
            this.ExpiryTB.Location = new System.Drawing.Point(460, 28);
            this.ExpiryTB.Name = "ExpiryTB";
            this.ExpiryTB.ReadOnly = true;
            this.ExpiryTB.Size = new System.Drawing.Size(154, 20);
            this.ExpiryTB.TabIndex = 34;
            this.ExpiryTB.TextChanged += new System.EventHandler(this.ExpiryTB_TextChanged);
            // 
            // ExtendMonth
            // 
            this.ExtendMonth.AutoSize = true;
            this.ExtendMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtendMonth.Location = new System.Drawing.Point(1143, 27);
            this.ExtendMonth.Name = "ExtendMonth";
            this.ExtendMonth.Size = new System.Drawing.Size(65, 21);
            this.ExtendMonth.TabIndex = 33;
            this.ExtendMonth.TabStop = true;
            this.ExtendMonth.Text = "Month";
            this.ExtendMonth.UseVisualStyleBackColor = true;
            this.ExtendMonth.CheckedChanged += new System.EventHandler(this.ExtendMonth_CheckedChanged);
            // 
            // ExtendYear
            // 
            this.ExtendYear.AutoSize = true;
            this.ExtendYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtendYear.Location = new System.Drawing.Point(1072, 27);
            this.ExtendYear.Name = "ExtendYear";
            this.ExtendYear.Size = new System.Drawing.Size(56, 21);
            this.ExtendYear.TabIndex = 32;
            this.ExtendYear.TabStop = true;
            this.ExtendYear.Text = "Year";
            this.ExtendYear.UseVisualStyleBackColor = true;
            this.ExtendYear.CheckedChanged += new System.EventHandler(this.ExtendYear_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(913, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Extend Expiry Date?";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.Crimson;
            this.Result.Location = new System.Drawing.Point(24, 71);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 18);
            this.Result.TabIndex = 30;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(642, 100);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 29;
            this.CancelBtn.Text = "CANCEL";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(539, 100);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 28;
            this.UpdateBtn.Text = "UPDATE";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "NAME";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(93, 28);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(209, 20);
            this.NameTB.TabIndex = 26;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // ViewMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MemberDetails);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewMembers";
            this.Load += new System.EventHandler(this.ViewMembers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.DataGridView MemberDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FineTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ExpiryTB;
        private System.Windows.Forms.RadioButton ExtendMonth;
        private System.Windows.Forms.RadioButton ExtendYear;
        private System.Windows.Forms.PictureBox CloseBox;
    }
}