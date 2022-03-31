using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryManagementSystem.DAO;
using LibraryManagementSystem.Entity;

namespace LibraryManagementSystem.Service
{
    class MemberService
    {
        private MemberDAO MemberDAO = new MemberDAO();

        public MEMBER getMemberById(int Id)
        {
            return MemberDAO.getMemberById(Id);
        }

        public List<MEMBER> getAllMembers()
        {
            return MemberDAO.getAllMembers();
        }

        public int addNewMember(string name)
        {
            MEMBER Member = new MEMBER();

            List<MEMBER> Members = MemberDAO.getAllMembers();
            Member.ID = !Members.Any() ? 1001 : Members.Last().ID + 1;
            Member.NAME = name;
            Member.FINE = 0;
            Member.EXPIRY = DateTime.Now.AddYears(1);

            return MemberDAO.addMember(Member);
        }

        public bool checkForExpiry(int Id)
        {
            MEMBER Member = this.getMemberById(Id);
            if (Member.EXPIRY > DateTime.Now)
                return true;
            return false;
        }

        public void updateMember(int Id, string Name, decimal Fine, DateTime Expiry)
        {
            MemberDAO.updateMember(Id, Name, Fine, Expiry);
        }
    }
}
