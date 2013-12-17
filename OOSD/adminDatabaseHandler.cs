using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD
{
    public class adminDatabaseHandler
    {
        

        private static int registrationNumber = 0;
        Connection connection;

        public adminDatabaseHandler()
        {
            connection = new Connection();

        }

        public void addUser(user newUser)
        {       //send newly created user object to connection object and finally to DB
            newUser.setregistrationNumber(++registrationNumber);
            connection.addUser(newUser);
        }

        public void resetPassword(string username, string password)
        {
            if (connection.getUserDetails(username) != null)    //check that user name exist
            {
                connection.setPassword(username, password);     //then change the password
            }
        }

        public void removeUser(string username)
        {
            if (connection.getUserDetails(username) != null)    //check that user name exist
            {
                connection.deleteUser(username);
            }
        }

        public void suspendUser(string username, int duration)
        {
            if (connection.getUserDetails(username) != null)    //check that user name exist
            {
                connection.suspendUser(username, duration);
            }
        }
    }
}
