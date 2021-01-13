using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Classess
{
    public class LoginUser
    {
        private string _phone_number;
        private string _password;

        public string Phone_number { get => _phone_number; set => _phone_number = value; }
        public string Password { get => _password; set => _password = value; }

        public LoginUser(string phone_number, string password)
        {
            Phone_number = phone_number;
            Password = password;
        }
        public LoginUser()
        {
        }
    }
}
