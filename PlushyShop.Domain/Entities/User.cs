namespace PlushyShop.Domain.Entities
{
    public class User : Entity
    {

        public string NickName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }

        public User(string nickName, string login, string password, string gender)
        {
            NickName = nickName;
            Login = login;
            Password = password;
            Gender = gender;
        }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
