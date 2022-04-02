using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibraryManagementSystem.Entity;
using LibraryManagementSystem.Service;

namespace LibraryManagementSystem.UI
{
    public partial class IssueBook : Form
    {
        private int BookId;
        private int MemberId;
        private DateTime IssueDate;
        private DateTime ReturnDate;
        private string IssuedBy;

        private BOOK Book;
        private int TotalCount;
        private int CurrentCount;
        private MEMBER Member;

        private BookService BookService = new BookService();
        private CountService CountService = new CountService();
        private MemberService MemberService = new MemberService();
        private IssueService IssueService = new IssueService();

        public IssueBook()
        {
            InitializeComponent();
        }

        public IssueBook(string IssuedBy)
        {
            InitializeComponent();
            this.IssuedBy = IssuedBy;
            this.IssuedByTB.Text = IssuedBy;
        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            IssueDate = IssuedOnDTP.Value = DateTime.Now;
            ReturnDate = ReturnDTP.Value = DateTime.Now.AddDays(7);
            CommentsTB.Text = "ISSUED";
        }

        private void BookTB_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            try
            {
                BookId = int.Parse(BookTB.Text);
            }
            catch (FormatException)
            {
                Result.Text = "Enter valid book id.";
            }
        }

        private void MemberTB_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            try
            {
                MemberId = int.Parse(MemberTB.Text);
            }
            catch (FormatException)
            {
                Result.Text = "Enter valid member id.";
            }
        }

        private void IssueBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(BookTB.Text))
            {
                Result.Text = "Please enter Book Id.";
            }else if (string.IsNullOrWhiteSpace(MemberTB.Text))
            {
                Result.Text = "Please enter Member Id.";
            }
            else
            {
                Book = BookService.getBookById(BookId);
                TotalCount = CountService.getTotalCount(BookId);
                CurrentCount = CountService.getCurrentCount(BookId);
                Member = MemberService.getMemberById(MemberId);

                if (Book == null)
                {
                    Result.Text = "Requested Book was not found.";
                }
                else if (Member == null)
                {
                    Result.Text = "Requested Member was not found.";
                }
                else
                {
                    if (CurrentCount <= 0)
                    {
                        Result.Text = "We don't have any more copies of " + Book.TITLE;
                    }
                    else if (Member.FINE > 0)
                    {
                        Result.Text = "The member has fines pending. Please clear dues to continue.";
                    }
                    else if (Member.EXPIRY < DateTime.Now)
                    {
                        Result.Text = "The membership for " + Member.NAME + " has expired.";
                    }
                    else
                    {
                        CountService.updateCurrentCount(BookId, CurrentCount - 1);
                        IssueService.issueBook(BookId, MemberId, IssuedBy, IssueDate, ReturnDate);
                        Result.Text = "A copy of the book '" + Book.TITLE + "' has been issued to " + Member.NAME + " successfully.\nNote - The return date is set to " + ReturnDate + ". \nHence, any delay in return would result in fine charged as per policy.";

                    }
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            BookTB.Text = string.Empty;
            MemberTB.Text = string.Empty;
            IssueDate = IssuedOnDTP.Value = DateTime.Now;
            ReturnDate = ReturnDTP.Value = DateTime.Now.AddDays(7);
            CommentsTB.Text = "ISSUED";
            Result.Text = string.Empty;
        }
    }
}
