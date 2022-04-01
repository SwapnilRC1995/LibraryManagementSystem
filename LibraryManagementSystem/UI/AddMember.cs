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

namespace LibraryManagementSystem.UI
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private MemberService MemberService = new MemberService();

        private string Name = string.Empty;
        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            Name = NameTB.Text;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Name))
            {
                try
                {
                    int Id = MemberService.addNewMember(Name);
                    Result.Text = "Member with Membership Number - " + Id + " has been added successfully.";

                }
                catch
                {
                    Result.Text = "A new member couldn't be added. Please try again later.";
                }
            }
        }
    }
}
