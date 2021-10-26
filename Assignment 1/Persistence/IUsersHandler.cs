using System.Collections.Generic;
using Models;

namespace FileData
{
    public interface IUsersHandler
    {
        public IList<User> Users { get; set; }

        public bool UserExists(string username);

        public void WriteNewUser(User NewUser);

        public User GetUser(string username);

    }
}