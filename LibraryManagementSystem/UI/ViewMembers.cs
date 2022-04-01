using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibraryManagementSystem.Service;
using LibraryManagementSystem.Entity;

namespace LibraryManagementSystem.UI
{
    public partial class ViewMembers : Form
    {
        private int selectedID;
        private string Name = string.Empty;
        private DateTime Expiry;
        private decimal Fine;
        private string Extend = string.Empty;

        private MemberService MemberService = new MemberService();

        public ViewMembers()
        {
            InitializeComponent();
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            Name = NameTB.Text;
        }

        private void ExpiryTB_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            if (string.IsNullOrWhiteSpace(ExpiryTB.Text))
            {
                Expiry = DateTime.Now;
            }
            else
            {
                Expiry = Convert.ToDateTime(ExpiryTB.Text);
            }
        }

        private void FineTB_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            try
            {
                Fine = decimal.Parse(FineTB.Text);
            }
            catch (FormatException)
            {
                Result.Text = "Fine should be a numeric value";
            }
        }

        private void ExtendYear_CheckedChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            Extend = "Y";
        }

        private void ExtendMonth_CheckedChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            Extend = "M";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            NameTB.Text = string.Empty;
            ExpiryTB.Text = string.Empty;
            FineTB.Text = string.Empty;
            ExtendYear.Checked = false;
            ExtendMonth.Checked = false;

            selectedID = 0;

            Result.Text = string.Empty;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if(selectedID != 0 && !string.IsNullOrWhiteSpace(Name) && Expiry != null && Fine >= 0)
            {
                try
                {
                    if (Extend.Equals("Y"))
                    {
                        Expiry = Expiry.AddYears(1);
                    }
                    else if(Extend.Equals("M"))
                    {
                        Expiry = Expiry.AddMonths(1);
                    }
                    MemberService.updateMember(selectedID, Name, Fine, Expiry);
                    CancelBtn_Click(sender, e);
                    Result.Text = "The member has been updated successfully.";
                }
                catch
                {
                    Result.Text = "Oops! Member update unsuccessful";
                    CancelBtn_Click(sender, e);
                }
            }
            else
            {
                Result.Text = "Oops! Fields cannot be left blank.";
            }
        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            List<MEMBER> Members = MemberService.getAllMembers();
            MemberDetails.DataSource = Members;
        }

        private void MemberDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && MemberDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                selectedID = int.Parse(MemberDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
                MEMBER Member = MemberService.getMemberById(selectedID);
                if(Member != null)
                {
                    NameTB.Text = Member.NAME;
                    ExpiryTB.Text = Member.EXPIRY.ToString();
                    FineTB.Text = Member.FINE.ToString();
                    ExpiryTB.Text = Member.EXPIRY.ToString();
                    
                }
            }
        }
    }
}
