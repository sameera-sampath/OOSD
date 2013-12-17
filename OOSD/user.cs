using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD
{
    public class user
    {
        private string username;

        private string firstName;
        private string middleName;
        private string lastName;

        private string postalNo;
        private string root;
        private string city;
        private string postalCode;

        private string grade;
        private string Class;

        private string homeTelephone;
        private string mobile;
        private string email;

        private string password;
        private string userState;

        private string userType;

        private string indexNo;

        private int registrationNumber;
        private DateTime registeredDate;

        private Connection connection;

        public user(int indexNo, string userState, string email, string password)
        {
            this.registrationNumber = indexNo;
            this.userState = userState;
            this.email = email;
            this.password = password;
            connection = new Connection();
        }

        public user()
        {
        }

        public void setusername(string name)
        {
            username = name;
        }

        public string getusername()
        {
            return username;
        }

        public void setregisteredDate(DateTime date)
        {
            registeredDate = date;
        }

        public DateTime getregisteredDate()
        {
            return registeredDate;
        }

        public void setregistrationNumber(int no)
        {
            registrationNumber = no;
        }

        public int getregistrationNumber()
        {
            return registrationNumber;
        }

        public void setindexNo(string no)
        {
            indexNo = no;
        }

        public string getindexNo()
        {
            return indexNo;
        }

        public void setuserType(string type)
        {
            userType = type;
        }

        public string getuserType()
        {
            return userType;
        }

        public void setuserState(string state)
        {
            userState = state;
        }

        public string getuserState()
        {
            return userState;
        }

        public void setpassword(string pss)
        {
            password = pss;
        }

        public string getpassword()
        {
            return password;
        }

        public void setemail(string addr)
        {
            email = addr;
        }

        public string getemail()
        {
            return email;
        }

        public void setmobile(string no)
        {
            mobile = no;
        }

        public string getmobile()
        {
            return mobile;
        }

        public void sethomeTelephone(string no)
        {
            homeTelephone = no;
        }

        public string gethomeTelephone()
        {
            return homeTelephone;
        }

        public void setClass(string CLass)
        {
            Class = CLass;
        }

        public string getClass()
        {
            return Class;
        }

        public void setGrade(string Grade)
        {
            grade = Grade;
        }

        public string getGrade()
        {
            return grade;
        }

        public void setPostalCode(string code)
        {
            postalCode = code;
        }

        public string getPostalCode()
        {
            return postalCode;
        }

        public void setCity(string City)
        {
            city = City;
        }

        public string getCity()
        {
            return city;
        }

        public void setRoot(string Root)
        {
            root = Root;
        }

        public string getRoot()
        {
            return root;
        }

        public void setPostalNo(string postal)
        {
            postalNo = postal;
        }

        public string getPostalNo()
        {
            return postalNo;
        }

        public void setFirstName(string name)
        {
            firstName = name;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public void setLastName(string name)
        {
            lastName = name;
        }

        public string getLastName()
        {
            return lastName;
        }

        public void setMiddleName(string name)
        {
            middleName = name;
        }

        public string getMiddleName()
        {
            return middleName;
        }


        public string getIndexNo()
        {
            return indexNo;
        }

        public void changePassword(string username, string newPassword)
        {
            password = newPassword;
            //connection.changeUserPassword(username, newPassword);
        }

        public void setPassword(string newPassword)
        {
            password = newPassword;
        }

        public string getPassword()
        {
            return password;
        }

        public void setEmail(string newEmail)
        {
            email = newEmail;
        }

        public string getEmail()
        {
            return email;
        }

        public string getID()
        {
            return indexNo;
        }

        public void setUserState(string state)
        {
            userState = state;
        }

        public string getUserState()
        {
            return userState;
        }


    }
}
