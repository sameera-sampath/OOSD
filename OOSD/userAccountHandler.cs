using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD
{
    
    public class userAccountHandler
    {
        private user currentUser;
        Connection connection;

        public userAccountHandler(user temp)
        {
            currentUser = temp;
            //connection = new Connection();
        }

        public string getCurrentPassword()
        {       
            return currentUser.getPassword();
        }

        public void changePassword(string password)
        {
            currentUser.changePassword(currentUser.getusername(),password);
        }

        public string getEmail()
        {
            return currentUser.getEmail();
        }

        public void changeEmail(string email)
        {
            currentUser.setEmail(email);
        }

        public void getBorrowHistory()
        {       //return the borrowing history and change void to nessasary return type

        }

        public int getNoOfReservations()
        {
            return connection.noOfReservations(currentUser.getusername());
        }

        public void getReservations()
        {       //return current reservations by reading the database

        }
    }
}
