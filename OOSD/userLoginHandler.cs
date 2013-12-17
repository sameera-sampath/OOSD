using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD
{
    class userLoginHandler
    {       //handle user login
        private Connection connection;
        user loginUser;

        public userLoginHandler()
        {
            connection = new Connection();
        }

        public Boolean userVerification(string username, string password)
        {
            if (connection.userIDValidation(username) == true)
            {
                if (connection.passwordValidation(username, password) == true)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public String usertype(String username)
        {
          return  connection.getUserState(username);
        }
    }

   
}
