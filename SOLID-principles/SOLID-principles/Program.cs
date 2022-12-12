using SOLID_principles;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserChecker checker = new UserChecker();
            User user = new User();
            string Username = "Nihad";
            string Email = "nihad20@gmail.com";
            string Password = "nihad123"; 
            
            User user2 = new User();
            user2.Username = "Kamil";
            user2.Email = "kamil2003@gmail.com";
            user2.Password = "kamil123";

            if (checker.CheckUsername(Username))
            {
                user.Username = Username;
            }
            if (checker.CheckEmail(Email))
            {
                user.Email = Email;
            }
            if (checker.CheckPassword(Password))
            {
                user.Password = Password;
            }

            UserCRUD userCRUD = new UserCRUD();

            userCRUD.CreateUser(user);
            userCRUD.CreateUser(user2);

            foreach(User item in userCRUD.GetAllUsers())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------");
            userCRUD.RemoveUser(user2);
            foreach (User item in userCRUD.GetAllUsers())
            {
                Console.WriteLine(item);
            }

        }
    }
}