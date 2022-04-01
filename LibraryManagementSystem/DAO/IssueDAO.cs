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
            return context.ISSUEs.Where(i => i.ID == Id && i.COMMENT.Equals("ISSUED")).FirstOrDefault();
        }

        public List<ISSUE> getIssuesByBookId(int BookId)
        {
            return context.ISSUEs.Where(i => i.BOOK_ID == BookId && i.COMMENT.Equals("ISSUED")).ToList<ISSUE>();
        }

        public List<ISSUE> getIssuesByMemberId(int MemberId)
        {
            return context.ISSUEs.Where(i => i.MEMBER_ID == MemberId && i.COMMENT.Equals("ISSUED")).ToList<ISSUE>();
        }

        public List<ISSUE> getIssuesByBookIdAndMemberId(int BookId, int MemberId)
        {
            return context.ISSUEs.Where(i => i.BOOK_ID == BookId && i.MEMBER_ID == MemberId && i.COMMENT.Equals("ISSUED")).ToList<ISSUE>();
        }

        public List<ISSUE> getAllIssues()
        {
            return context.ISSUEs.Where(i => i.COMMENT.Equals("ISSUED")).ToList<ISSUE>();
        }

        public List<ISSUE> getAllReturns()
        {
            return context.ISSUEs.Where(i => i.COMMENT.Equals("RETURNED")).ToList<ISSUE>();
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

        public void returnBook(int Id)
        {
            ISSUE Issue = context.ISSUEs.SingleOrDefault(i => i.ID == Id);
            if (Issue != null)
            {
                Issue.COMMENT = "RETURNED";

                context.SaveChanges();
            }
        }

        public void removeIssue(int Id)
        {

        }
    }
}
