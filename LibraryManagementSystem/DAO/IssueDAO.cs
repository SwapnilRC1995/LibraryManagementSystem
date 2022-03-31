using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryManagementSystem.Entity;

namespace LibraryManagementSystem.DAO
{
    class IssueDAO
    {
        private LMSEntities context = new LMSEntities();

        public ISSUE getIssueById(int Id)
        {
            return context.ISSUEs.Where(i => i.ID == Id).FirstOrDefault();
        }

        public List<ISSUE> getIssuesByBookId(int BookId)
        {
            return context.ISSUEs.Where(i => i.BOOK_ID == BookId).ToList<ISSUE>();
        }

        public List<ISSUE> getAllIssues()
        {
            return context.ISSUEs.ToList<ISSUE>();
        }

        public int issueBook(ISSUE Issue)
        {
            ISSUE i = context.ISSUEs.Add(Issue);
            context.SaveChanges();
            return i.ID;
        }

        public void updateIssue(int Id, int BookId, int MemberId, DateTime IssueDate, DateTime ReturnDate, string IssuedBy, string Comment)
        {
            ISSUE Issue = context.ISSUEs.SingleOrDefault(i => i.ID == Id);
            if(Issue != null)
            {
                Issue.BOOK_ID = BookId;
                Issue.MEMBER_ID = MemberId;
                Issue.ISSUE_DATE = IssueDate;
                Issue.RETURN_DATE = ReturnDate;
                Issue.ISSUED_BY = IssuedBy;
                Issue.COMMENT = Comment;

                context.SaveChanges();
            }
        }

        public void removeIssue(int Id)
        {

        }
    }
}
