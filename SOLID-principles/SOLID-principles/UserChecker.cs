using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles
{
    internal class UserChecker
    {
        public bool CheckUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length>25 || username.Length<5)
                return false;   
            return true;
        }
        public bool CheckEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || email.Length > 25 || email.Length < 5)
                return false;
            return true;
        }
        public bool CheckPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length > 25 || password.Length < 8)
                return false;
            return true;
        }
    }
}
