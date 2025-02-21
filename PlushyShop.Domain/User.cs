using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlushyShop.Domain
{
    class User
    {
        public User(string nickName, string login, string password, string town, string gender)
        {
            NickName = nickName;
            Login = login;
            Password = password;
            Town = town;
            Gender = gender;
        }

        public string NickName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Town { get; set; }
        public string Gender { get; set; }
    }
}
