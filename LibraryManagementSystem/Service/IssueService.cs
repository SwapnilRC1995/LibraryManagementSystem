using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryManagementSystem.DAO;
using LibraryManagementSystem.Entity;

namespace LibraryManagementSystem.Service
{
    class IssueService
    {
        private IssueDAO IssueDAO = new IssueDAO();

        public ISSUE getIssueById(int Id)
        {
            return IssueDAO.getIssueById(Id);
        }

        public List<ISSUE> getAllIssues()
        {
            return IssueDAO.getAllIssues();
        }

        public List<ISSUE> getIssuesByBookId(int BookId)
        {
            return IssueDAO.getIssuesByBookId(BookId);
        }

        public List<ISSUE> getIssuesByMemberId(int MemberId)
        {
            return IssueDAO.getIssuesByMemberId(MemberId);
        }

        public List<ISSUE> getIssuesByBookIdAndMemberId(int BookId, int MemberId)
        {
            return IssueDAO.getIssuesByBookIdAndMemberId(BookId, MemberId);
        }

        public int issueBook(int BookId, int MemberId, string IssuedBy, DateTime IssuedOn, DateTime ReturnBy)
        {
            ISSUE Issue = new ISSUE();
            Issue.BOOK_ID = BookId;
            Issue.MEMBER_ID = MemberId;
            Issue.ISSUE_DATE = IssuedOn;
            Issue.RETURN_DATE = ReturnBy;
            Issue.ISSUED_BY = IssuedBy;
            Issue.COMMENT = "ISSUED";

            List<ISSUE> Issues = IssueDAO.getAllIssues();
            Issue.ID = !Issues.Any() ? 1001 : Issues.Last().ID + 1;

            return IssueDAO.issueBook(Issue);
        }

        public void returnBook(int Id)
        {
            IssueDAO.returnBook(Id);
        }

        public DateTime reIssueBook(int Id)
        {
            return IssueDAO.reIssueBook(Id);
        }

    }
}
