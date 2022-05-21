using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIUGlab2_4
{
    internal class Users
    {
        String name, password;

        public Users(String name, String password)
        {
            this.name = name;
            this.password = password;
        }

        public String Name { get { return name; } }

        public bool CheckPassword(string inputPassword)
        {
            if (password == inputPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
