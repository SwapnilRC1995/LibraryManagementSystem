
namespace LibraryManagementSystem.UI
{
    partial class ViewBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.BookDetails = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Result = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PublisherTB = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeSoftCover = new System.Windows.Forms.RadioButton();
            this.TypeHardCover = new System.Windows.Forms.RadioButton();
            this.CountTB = new System.Windows.Forms.TextBox();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.AuthorTB = new System.Windows.Forms.TextBox();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.TitleTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.IsbnTB = new System.Windows.Forms.TextBox();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDetails)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CloseBox);
            this.panel1.Controls.Add(this.header);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 65);
            this.panel1.TabIndex = 0;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(504, 14);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(208, 37);
            this.header.TabIndex = 1;
            this.header.Text = "Book Details";
            // 
            // BookDetails
            // 
            this.BookDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BookDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.BookDetails.Location = new System.Drawing.Point(12, 84);
            this.BookDetails.Name = "BookDetails";
            this.BookDetails.ReadOnly = true;
            this.BookDetails.Size = new System.Drawing.Size(1241, 295);
            this.BookDetails.TabIndex = 1;
            this.BookDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDetails_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Result);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.PublisherTB);
            this.panel2.Controls.Add(this.CancelBtn);
            this.panel2.Controls.Add(this.UpdateBtn);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TypeSoftCover);
            this.panel2.Controls.Add(this.TypeHardCover);
            this.panel2.Controls.Add(this.CountTB);
            this.panel2.Controls.Add(this.CategoryCB);
            this.panel2.Controls.Add(this.AuthorTB);
            this.panel2.Controls.Add(this.DescriptionTB);
            this.panel2.Controls.Add(this.TitleTB);
            this.panel2.Controls.Add(this.PriceTB);
            this.panel2.Controls.Add(this.IsbnTB);
            this.panel2.Location = new System.Drawing.Point(12, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1241, 258);
            this.panel2.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.Crimson;
            this.Result.Location = new System.Drawing.Point(29, 168);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 18);
            this.Result.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 18);
            this.label9.TabIndex = 45;
            this.label9.Text = "PUBLISHER";
            // 
            // PublisherTB
            // 
            this.PublisherTB.Location = new System.Drawing.Point(142, 130);
            this.PublisherTB.Name = "PublisherTB";
            this.PublisherTB.Size = new System.Drawing.Size(420, 20);
            this.PublisherTB.TabIndex = 44;
            this.PublisherTB.TextChanged += new System.EventHandler(this.PublisherTB_TextChanged);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(627, 209);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 43;
            this.CancelBtn.Text = "CANCEL";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(511, 209);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 41;
            this.UpdateBtn.Text = "UPDATE";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(952, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 40;
            this.label8.Text = "AUTHOR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(584, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "CATEGORY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(953, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 38;
            this.label6.Text = "COUNT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(583, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "TYPE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(954, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "PRICE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "DESCRIPTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "ISBN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "TITLE";
            // 
            // TypeSoftCover
            // 
            this.TypeSoftCover.AutoSize = true;
            this.TypeSoftCover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeSoftCover.Location = new System.Drawing.Point(824, 78);
            this.TypeSoftCover.Name = "TypeSoftCover";
            this.TypeSoftCover.Size = new System.Drawing.Size(86, 21);
            this.TypeSoftCover.TabIndex = 32;
            this.TypeSoftCover.TabStop = true;
            this.TypeSoftCover.Text = "Softcover";
            this.TypeSoftCover.UseVisualStyleBackColor = true;
            this.TypeSoftCover.CheckedChanged += new System.EventHandler(this.TypeSoftCover_CheckedChanged);
            // 
            // TypeHardCover
            // 
            this.TypeHardCover.AutoSize = true;
            this.TypeHardCover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeHardCover.Location = new System.Drawing.Point(696, 78);
            this.TypeHardCover.Name = "TypeHardCover";
            this.TypeHardCover.Size = new System.Drawing.Size(92, 21);
            this.TypeHardCover.TabIndex = 31;
            this.TypeHardCover.TabStop = true;
            this.TypeHardCover.Text = "Hardcover";
            this.TypeHardCover.UseVisualStyleBackColor = true;
            this.TypeHardCover.CheckedChanged += new System.EventHandler(this.TypeHardCover_CheckedChanged);
            // 
            // CountTB
            // 
            this.CountTB.Location = new System.Drawing.Point(1028, 126);
            this.CountTB.Name = "CountTB";
            this.CountTB.Size = new System.Drawing.Size(176, 20);
            this.CountTB.TabIndex = 30;
            this.CountTB.TextChanged += new System.EventHandler(this.CountTB_TextChanged);
            // 
            // CategoryCB
            // 
            this.CategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(699, 126);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(214, 21);
            this.CategoryCB.TabIndex = 29;
            this.CategoryCB.SelectedIndexChanged += new System.EventHandler(this.CategoryCB_SelectedIndexChanged);
            // 
            // AuthorTB
            // 
            this.AuthorTB.Location = new System.Drawing.Point(1028, 79);
            this.AuthorTB.Name = "AuthorTB";
            this.AuthorTB.Size = new System.Drawing.Size(176, 20);
            this.AuthorTB.TabIndex = 28;
            this.AuthorTB.TextChanged += new System.EventHandler(this.AuthorTB_TextChanged);
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(142, 79);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(420, 20);
            this.DescriptionTB.TabIndex = 27;
            this.DescriptionTB.TextChanged += new System.EventHandler(this.DescriptionTB_TextChanged);
            // 
            // TitleTB
            // 
            this.TitleTB.Location = new System.Drawing.Point(420, 37);
            this.TitleTB.Name = "TitleTB";
            this.TitleTB.Size = new System.Drawing.Size(507, 20);
            this.TitleTB.TabIndex = 26;
            this.TitleTB.TextChanged += new System.EventHandler(this.TitleTB_TextChanged);
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(1026, 37);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(176, 20);
            this.PriceTB.TabIndex = 25;
            this.PriceTB.TextChanged += new System.EventHandler(this.PriceTB_TextChanged);
            // 
            // IsbnTB
            // 
            this.IsbnTB.Location = new System.Drawing.Point(86, 37);
            this.IsbnTB.Name = "IsbnTB";
            this.IsbnTB.Size = new System.Drawing.Size(214, 20);
            this.IsbnTB.TabIndex = 24;
            this.IsbnTB.TextChanged += new System.EventHandler(this.IsbnTB_TextChanged);
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
            this.CloseBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ViewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1265, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BookDetails);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBooks";
            this.Load += new System.EventHandler(this.ViewBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.DataGridView BookDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PublisherTB;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton TypeSoftCover;
        private System.Windows.Forms.RadioButton TypeHardCover;
        private System.Windows.Forms.TextBox CountTB;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.TextBox AuthorTB;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.TextBox TitleTB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.TextBox IsbnTB;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.PictureBox CloseBox;
    }
}