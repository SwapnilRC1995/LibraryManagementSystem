using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryManagementSystem.Entity;

namespace LibraryManagementSystem.DAO
{
    class UserDAO
    {
        private LMSEntities context = new LMSEntities();
        
        public USER GetUserByUsername(string Username)
        {
            return context.USERs.Where(u => u.USERNAME == Username).FirstOrDefault();
        }
    }
}
