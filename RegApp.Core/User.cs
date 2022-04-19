using System.Collections.Generic;
using System.Linq;

namespace RegApp.Core
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
        
        public static bool CheckLoginCredetionals(string login, string password, List<User> userslist)
        {
            return userslist.Any(person => (person.Login == login) & (person.Password == password));
        }
        
        public static bool LoginExistsCheck(string login, List<User> usersList)
        {
            return usersList.Any(person => (person.Login == login));
        }
        
        public static User LogIn(string login, string password, List<User> userslist)
        {
            while (true)
            {
                foreach (var person in userslist.Where(person => (person.Login == login)))
                {
                    return person;
                }
            }
        }

        public static void Registration(string login, string password, List<User> usersList)
        {
            User newUser = new User(login, password);
            usersList.Add(newUser);
        }
    }
}