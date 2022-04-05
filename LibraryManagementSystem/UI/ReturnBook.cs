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
using LibraryManagementSystem.Utils;

namespace LibraryManagementSystem.UI
{
    public partial class ReturnBook : Form
    {
        private int selectedID;

        private string selectedView;
        private int MemberIdSelect;
        private int BookIdSelect;

        private int BookId;
        private int MemberId;
        private string IssuedBy;
        private DateTime IssueDate;
        private DateTime ReturnDate;
        private string Comment;

        private IssueService IssueService = new IssueService();
        private CountService CountService = new CountService();
        private MemberService MemberService = new MemberService();
        private FineUtils Utils = new FineUtils();

        public ReturnBook()
        {
            InitializeComponent();
        }

        private void MemberRB_CheckedChanged(object sender, EventArgs e)
        {
            MemberL.Visible = true;
            MemberTB.Visible = true;

            BookL.Visible = false;
            BookTB.Visible = false;

            selectedView = "member";
        }

        private void BookRB_CheckedChanged(object sender, EventArgs e)
        {
            MemberL.Visible = false;
            MemberTB.Visible = false;

            BookL.Visible = true;
            BookTB.Visible = true;

            selectedView = "book";
        }

        private void MemberAndBookRB_CheckedChanged(object sender, EventArgs e)
        {
            MemberL.Visible = true;
            MemberTB.Visible = true;

            BookL.Visible = true;
            BookTB.Visible = true;

            selectedView = "memberandbook";
        }

        private void NoneRB_CheckedChanged(object sender, EventArgs e)
        {
            MemberL.Visible = false;
            MemberTB.Visible = false;

            BookL.Visible = false;
            BookTB.Visible = false;

            selectedView = "none";
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookTBR_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            try
            {
                BookId = int.Parse(BookTBR.Text);
            }
            catch (FormatException)
            {
                Result.Text = "Enter valid book id.";
            }
        }

        private void MemberTBR_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            try
            {
                MemberId = int.Parse(MemberTBR.Text);
            }
            catch (FormatException)
            {
                Result.Text = "Enter valid member id.";
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            selectedID = 0;

            BookTBR.Text = string.Empty;
            MemberTBR.Text = string.Empty;
            IssueDate = IssuedOnDTP.Value = DateTime.Now;
            ReturnDate = ReturnDTP.Value = DateTime.Now;
            CommentsTB.Text = string.Empty;
            Result.Text = string.Empty;
        }

        private void BookDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && IssueDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                selectedID = int.Parse(IssueDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
                ISSUE Issue = IssueService.getIssueById(selectedID);
                if (Issue != null && Issue.COMMENT.Equals("ISSUED"))
                {
                    BookTBR.Text = Issue.BOOK_ID + "";
                    MemberTBR.Text = Issue.MEMBER_ID + "";
                    IssuedByTB.Text = Issue.ISSUED_BY;
                    IssuedOnDTP.Value = Issue.ISSUE_DATE;
                    ReturnDTP.Value = Issue.RETURN_DATE;
                    CommentsTB.Text = Issue.COMMENT;
                }
                else
                {
                    Result.Text = "Book has already been returned.";
                }
                
            }
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            IssueDetails.DataSource = IssueService.getAllIssues();
            IssueDate = IssuedOnDTP.Value = DateTime.Now;
            ReturnDate = ReturnDTP.Value = DateTime.Now;
            CommentsTB.Text = string.Empty;
        }

        private void MemberTB_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            try
            {
                MemberIdSelect = int.Parse(MemberTB.Text);
            }
            catch (FormatException)
            {
                Result.Text = "Enter valid member id.";
            }
        }

        private void BookTB_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            try
            {
                BookIdSelect = int.Parse(BookTB.Text);
            }
            catch (FormatException)
            {
                Result.Text = "Enter valid book id.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedView.Equals("none"))
            {
                List<ISSUE> Issues = IssueService.getAllIssues().Where(i => i.COMMENT.Equals("ISSUED")).ToList();
                if (Issues.Any())
                {
                    IssueDetails.DataSource = Issues;
                }
                else
                {
                    Result.Text = "No rows returned";
                }
            }
            else if (selectedView.Equals("member"))
            {
                List<ISSUE> Issues = IssueService.getIssuesByMemberId(MemberIdSelect).Where(i => i.COMMENT.Equals("ISSUED")).ToList();
                if (Issues.Any())
                {
                    IssueDetails.DataSource = Issues;
                }
                else
                {
                    IssueDetails.DataSource = null;
                    Result.Text = "No rows returned";
                }
            }
            else if (selectedView.Equals("book"))
            {
                List<ISSUE> Issues = IssueService.getIssuesByBookId(BookIdSelect).Where(i => i.COMMENT.Equals("ISSUED")).ToList();
                if (Issues.Any())
                {
                    IssueDetails.DataSource = Issues;
                }
                else
                {
                    IssueDetails.DataSource = null;
                    Result.Text = "No rows returned";
                }
            }
            else if (selectedView.Equals("memberandbook"))
            {
                List<ISSUE> Issues = IssueService.getIssuesByBookIdAndMemberId(BookIdSelect, MemberIdSelect).Where(i => i.COMMENT.Equals("ISSUED")).ToList();
                if (Issues.Any())
                {
                    IssueDetails.DataSource = Issues;
                }
                else
                {
                    IssueDetails.DataSource = null;
                    Result.Text = "No rows returned";
                }
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(BookTBR.Text))
            {
                try
                {
                    ISSUE Issue = IssueService.getIssueById(selectedID);
                    decimal fine = 0;
                    if (Issue.RETURN_DATE < DateTime.Now && Utils.calculateDaysExceeded(ReturnDate) > 0)
                    {
                        fine = Utils.calculateTotalFine(Utils.calculateDaysExceeded(ReturnDate));
                    }
                    int currentCount = CountService.getCurrentCount(BookId);
                    if(fine > 0)
                    {
                        MEMBER Member = MemberService.getMemberById(MemberId);
                        MemberService.updateMember(Member.ID, Member.NAME, fine, Member.EXPIRY);
                    }
                    IssueService.returnBook(selectedID);

                    CountService.updateCurrentCount(BookId, currentCount + 1);
                    Result.Text = "The book has been returned successfully.";
                }
                catch
                {
                    Result.Text = "There was a problem returning the book. Try again later.";
                }
            }
            else
            {
                    Result.Text = "Please select an issue to continue.";
            }

        }

        private void ReIssueBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(BookTBR.Text))
            {
                try
                {
                    ISSUE Issue = IssueService.getIssueById(selectedID);
                    decimal fine = 0;
                    if (Issue.RETURN_DATE < DateTime.Now && Utils.calculateDaysExceeded(ReturnDate) > 0)
                    {
                        fine = Utils.calculateTotalFine(Utils.calculateDaysExceeded(ReturnDate));
                    }
                    int currentCount = CountService.getCurrentCount(BookId);
                    if (fine > 0)
                    {
                        MEMBER Member = MemberService.getMemberById(MemberId);
                        MemberService.updateMember(Member.ID, Member.NAME, fine, Member.EXPIRY);
                    }

                    DateTime ret = IssueService.reIssueBook(selectedID);
                    Result.Text = "The book has been re-issued. \nNote - The return date is set to " + ret + ". \nHence, any delay in return would result in fine charged as per policy.";
                }
                catch
                {
                    Result.Text = "There was a problem re-issuing the book. Try again later.";
                }
            }
            else
            {
                Result.Text = "Please select an issue to continue.";
            }
        }
    }
}
