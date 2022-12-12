using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles
{
    internal class UserCRUD
    {
        public void CreateUser(User user)
        {
            Database.Users.Add(user);
        }
        public void RemoveUser(User user)
        {
            Database.Users.Remove(user);
        }

        public List<User> GetAllUsers()
        {
            return Database.Users;
        }
    }
}
