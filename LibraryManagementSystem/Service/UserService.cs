using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryManagementSystem.DAO;
using LibraryManagementSystem.Entity;
using LibraryManagementSystem.Exceptions;

namespace LibraryManagementSystem.Service
{
    class UserService
    {
        private UserDAO UserDAO = new UserDAO();

        public USER GetUserByUsername(string Username, string Password)
        {
            USER User = UserDAO.GetUserByUsername(Username);
            if (User != null)
            {
                if (User.PASSWORD.Equals(Password))
                {
                    return User;
                }
                else
                {
                    throw new PasswordMissmatchException();
                }
                
            }
            else
            {
                throw new UserNotFoundException();
            }

        }
    }
}
