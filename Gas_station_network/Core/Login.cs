using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station_network.Core
{
    class Login
    {
        private string _username;
        private string _password;

        public string Username {get; set;}

        public string Password { get; set;}

        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
