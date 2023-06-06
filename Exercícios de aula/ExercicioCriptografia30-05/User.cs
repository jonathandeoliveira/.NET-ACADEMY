using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCriptografia30_05
{
    internal class User
    {
        public string Login;
        public string Password;

        public User(string user, string password)
        {
            this.Login = user;
            this.Password = password;
        }
    }
}
