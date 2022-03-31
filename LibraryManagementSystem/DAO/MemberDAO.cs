using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryManagementSystem.Entity;

namespace LibraryManagementSystem.DAO
{
    class MemberDAO
    {
        private LMSEntities context = new LMSEntities();

        public MEMBER getMemberById(int Id)
        {
            return context.MEMBERs.Where(m => m.ID == Id).FirstOrDefault();
        }

        public List<MEMBER> getAllMembers()
        {
            return context.MEMBERs.ToList();
        }

        public int addMember(MEMBER Member)
        {
            MEMBER m = context.MEMBERs.Add(Member);
            context.SaveChanges();
            return m.ID;
        }

        public void updateMember(int Id, string Name, decimal Fine, DateTime Expiry)
        {
            MEMBER Member = context.MEMBERs.SingleOrDefault(m => m.ID == Id);
            if(Member != null)
            {
                Member.NAME = Name;
                Member.FINE = Fine;
                Member.EXPIRY = Expiry;

                context.SaveChanges();
            }
        }

        public void removeMember()
        {

        }
    }
}
