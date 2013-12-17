using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySql.Data.Types;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace OOSD
{
    public class Connection
    {       //conection to database
        private String connectionString;
        private String sql;
        private MySqlConnection con;
        private MySqlDataReader dr;
        private MySqlCommand cmd;


        public Connection()        //Constructor
        {
            // MessageBox.Show("in");
            try
            {
                connectionString = "server=54.254.169.189;Uid=sameera;password=sameera;Persist Security Info=True;database=Library";
                //connectionString = "Server=localhost;Database=passwords;Uid=root;Pwd=Amila@23;";
                con = new MySqlConnection(connectionString);
                con.Open();
                //  MessageBox.Show("connected to the database");

                //sql = "select * from Login_Details where User_Name = '"+;
                cmd = new MySqlCommand(sql, con);
                //dr = cmd.ExecuteReader();
                // dr.Close();
                //MessageBox.Show("connected to the database");


            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString());
            }
        }

        public string lending(string bookID, string userName)
        {       //lending books
            //must return the due date as a string

            //check admin/user level table that how many books, user can borrow books
            //get the number of currently borrowed books
            //issue if user can get a book
            //else erroe massage
            //increase  y 1 login table count
            //update issue table
            //check that user is suspended

            sql = " SELECT * FROM Login_Details WHERE User_Name = '" + userName + "';";
            cmd.CommandText = sql;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)   // check whether username exists
            {
                dr.Read();                          // check whether user suspended
                if (dr[4].ToString() == "False") // if not suspended proceed lending process
                {

                    String userLevel = getUserLevel(userName);

                    sql = "SELECT * FROM Administration WHERE User_Level = '" + userLevel + "';";
                    cmd.CommandText = sql;
                    dr.Close();
                    dr = cmd.ExecuteReader();

                    dr.Read();


                    int maxNoOFbooks = Convert.ToInt32(dr[5].ToString()); // gete max noof books
                    dr.Close();

                    sql = "SELECT * FROM Login_Details WHERE User_Name = '" + userName + "';";
                    cmd.CommandText = sql;
                    dr = cmd.ExecuteReader();

                    dr.Read();

                    int currentNoOfbooks = Convert.ToInt32(dr[5].ToString());

                    dr.Close();

                    if (maxNoOFbooks > currentNoOfbooks) // proceed lending
                    {

                        sql = "SELECT * FROM book_copy WHERE book_id = '" + bookID + "';";
                        cmd.CommandText = sql;
                        dr = cmd.ExecuteReader();

                        dr.Read();

                        if (dr[5].ToString() == "True")  // book is available
                        {
                            dr.Close();

                            sql = "UPDATE Login_Details SET Book_Count = " + (Convert.ToInt32(currentNoOfbooks) + 1) + " WHERE User_Name = '" + userName + "';";
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();

                            sql = "UPDATE book_copy SET availability = 'False' where  book_id = '" + bookID + "';";
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();

                            DateTime returnday = DateTime.Now.AddDays(14);
                            // sql = "INSERT INTO issue SET user_name ='"+userName+"',book_id = "+ Convert.ToInt32(bookID)+",issue_date = '"+DateTime.Today+"', add return date );

                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();



                            //  MessageBox.Show("lending process complete return date "+returnday);

                            return returnday.Date.ToString(); // lack of commands


                        }
                        else
                        {
                            dr.Close();
                            MessageBox.Show("Book is not available");
                        }

                    }

                    else
                    {
                        MessageBox.Show("Maximum number of books are taken");
                    }


                }

                else
                {
                    dr.Close();
                    MessageBox.Show("User is suspended");
                }
            }

            else
            {
                MessageBox.Show("user name Not Found");
            }
            return null;
        }

        public string returning(string bookID, string userName)
        {       //returning books
            //must return the fine due to late returning 
            //null if no fine

            sql = "SELECT * FROM Login_Details WHERE User_Name = '" + userName + "';";
            cmd.CommandText = sql;
            dr = cmd.ExecuteReader();

            dr.Read();
            String currentvalue = dr[5].ToString();
            dr.Close();

            sql = "SELECT * FROM book_copy   WHERE  book_id = " + bookID + ";";

            cmd.CommandText = sql;
            dr = cmd.ExecuteReader();

            dr.Read();
            if (dr[5].ToString() == "True")
            {
                dr.Close();
                MessageBox.Show("book is currently in the library");
                return null;
            }

            sql = "UPDATE Login_Details SET Book_Count = " + (Convert.ToInt32(currentvalue) - 1) + " WHERE User_Name = '" + userName + "';";
            dr.Close();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            sql = "UPDATE book_copy SET availability = 'True' WHERE  book_id = " + bookID + ";";
            cmd.CommandText = sql;
            // MessageBox.Show(bookID+"    "+userName);
            cmd.ExecuteNonQuery();

            return "No fines";

        }

        public DataSet getBorrowHistory(string userName)
        {       //return borrowing history dataset
            sql = "SELECT * from issue WHERE user_name = '" + userName + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "std");

            return ds;

        }

        public DataSet getReservations(string userName)
        {       //return reservations dataset

            sql = "SELECT * from reservation WHERE user_name = '" + userName + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "std");

            return ds;
        }

        public int noOfReservations(string username)
        {       //read DB and return the number of reservations
            return 0;
        }

        public DateTime lendBook(string bookID, string username, DateTime time)
        {       //return due date
            return time;
        }

        public DateTime returnBook(string bookID, string username, DateTime time)
        {       //must return the due date of the book
            return time;        //change this
        }

        public string getUserPassword(string username)
        {       //return the current password of the user temp by reading DB
                //  MessageBox.Show("in the method");
            sql = "select * from Login_Details where User_Name = '" + username + "'";
            cmd = new MySqlCommand(sql, con);

            dr = cmd.ExecuteReader();

            cmd.Dispose();
            if (dr.HasRows)
            {
                dr.Read();

                return dr[2].ToString();
            }
            else
            {

                return null;
            }
        }

        public void changeUserPassword(string username, string oldPassword, string newpssword1, string newpssword2)
        {       //change password of the user by himself
                // inform user about the 
            cmd.CommandText = "select * from Login_Details where User_Name = '" + username + "';";
             dr = cmd.ExecuteReader();

             if (dr.HasRows)
             {
                 dr.Read();

                 if (dr[1].ToString() == oldPassword)
                 {
                     if (newpssword1 == newpssword2)
                     {
                         cmd.CommandText = " UPDATE Login_Details SET Password = '" + newpssword1 + "', Old_Password = '" + oldPassword + "' WHERE User_Name = '" + username + "';";
                         dr.Close();
                         cmd.ExecuteNonQuery();
                         dr.Close();
                         MessageBox.Show("password changed successfully");
                     }

                     else
                     {
                         MessageBox.Show("new passwords did not match");
                         dr.Close();
                     }
                 }
                 else 
                 {
                     dr.Close();
                     MessageBox.Show("incorrect password");
                 }



             }
             else
             {
                 dr.Close();
                 MessageBox.Show("user name not found");
             }




        }

        public void changeUserEmail(string username, string pswrd, string email)
        {   //check for user name
            //then for password
            //then change email address
            cmd.CommandText = "SELECT * FROM Login_Details WHERE User_Name = '" + username + "';";

            try
            {

                dr = cmd.ExecuteReader();
            }
            catch (Exception e5)
            {
                MessageBox.Show(e5.ToString());
            }

            if (dr.HasRows)
            {
                dr.Read();

                if (dr[1].ToString() == pswrd)
                {
                    dr.Close();
                    cmd.CommandText = "UPDATE User SET e_mail = '" + email + "' WHERE user_name = '" + username + "';";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("email changed successfully");
                }
                else
                {
                    MessageBox.Show("wrong password");
                }
            }
            else
            {
                MessageBox.Show("invalid username");
                dr.Close();
            }

        }

        public void setPassword(string username, string password)
        {   //change user password by staff or admin
            cmd.CommandText = "UPDATE Login_Details SET Password = '" + password + "' WHERE User_Name = '" + username + "';";
            cmd.ExecuteNonQuery();
            MessageBox.Show("successfully changed");
        }

        public void setReserv(String User_Name, String title_id)
        {
            dr.Close();
            cmd.CommandText = "UPDATE Login_Details SET Reservation_Count = Reservation_Count+1 WHERE User_Name = '" + User_Name + "';";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Login_Details changed");
            cmd.CommandText = "UPDATE library_book_title SET no_of_reservations = no_of_reservations+1 WHERE title_id = '" + title_id + "';";
            cmd.ExecuteNonQuery();
            MessageBox.Show("library_book_title changed");
        }

        public void addUser(user tempUser)
        {       //add users to database
            sql = "INSERT INTO User VALUES ('" + tempUser.getusername() + "','" + tempUser.getFirstName() + "','" + tempUser.getMiddleName() + "','" + tempUser.getLastName() + "','" + tempUser.getRoot() + "','" + tempUser.getCity() + "','" + tempUser.getemail() + "','" + tempUser.gethomeTelephone() + "','" + tempUser.GetType() + "');";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            sql = "INSERT INTO Login_Details VALUES ('" + tempUser.getusername() + "','zaq@123', NULL,'" + DateTime.Today + "','False';";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            // vary with the type of user
        }

        public void deleteUser(string username)
        {       //delete user details permenently from database
            sql = "DELETE FROM Login_Details WHERE User_Name = '" + username + "';";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            sql = "DELETE FROM Login_Details WHERE user_name = '" + username + "';";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

        }

        public void suspendUser(string username, int duration)
        {       //suspend user for number of 'duration' days
            sql = "UPDATE Login_Details SET Suspend = 'True' WHERE User_Name = '" + username + "';";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

        }

        public void updateUserState(string username)
        {       //upgrade user state  (eg: from staff to admin....)

        }

        public Boolean userIDValidation(string username)
        {       //check Db for the ID and return true is found

                //  MessageBox.Show("useridvalidation");
            sql = "select * from Login_Details where User_Name = '" + username + "';";

            MySqlConnection con1 = new MySqlConnection();
            // con1.ConnectionString = "server=54.254.169.189;Uid=sameera;password=sameera;Persist Security Info=True;database=Library";

            // con1.Open();
            cmd.CommandText = sql;
            //  MessageBox.Show("useridvalidation 2");

            try
            {
                dr = cmd.ExecuteReader();
                //  con.Close();
            }
            catch (Exception e4)
            {
                MessageBox.Show("e4 " + e4.ToString());
            }
            cmd.Dispose();
            if (dr.HasRows)
            {
                dr.Close();
                return true;
            }
            else
            {
                // MessageBox.Show("has no row");
                dr.Close();
                return false;
            }
        }

        public Boolean passwordValidation(string username, string password)
        {       //check Db for the ID and password and return true the combination is correct
                // MessageBox.Show("passwordvalidation");
                // con.Open();
            sql = "select * from Login_Details where User_Name = '" + username + "';";
                //  MySqlConnection con3 = new MySqlConnection("server=54.254.169.189;Uid=sameera;password=sameera;Persist Security Info=True;database=Library");
                //  con3.Open();
            cmd.CommandText = sql;
            dr = cmd.ExecuteReader();

            dr.Read();
            // con3.Close();
            if (dr[1].ToString() == password)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean getUserDetails(string username)
        {       //check for validation of a username and password

            /*try
            {
                con.Open();
            }
            catch (Exception EX)
            {
                MessageBox.Show("Unable to connect to Database");Lo
            }*/
            String query = "select * from Login_Details where User_Name = '" + username + "'";
            MySqlCommand command = new MySqlCommand(query, con);
            dr = command.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Close();
                return true;
            }

            else
            {
                return false;
            }
        }

        public String getUserState(String username)
        {
            sql = "select * from User where user_name = '" + username + "';";
            cmd.CommandText = sql;
            dr.Close();
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr[8].ToString() == "Student")
            {
                sql = "select Administration.User_Level from Administration JOIN Class_Teacher ON Administration.Grade = Class_Teacher.Grade JOIN Student ON (Class_Teacher.Grade = Student.Grade AND Class_Teacher.Class = Student.Class) where Student.User_Name = '" + username + "';";
                cmd.CommandText = sql;
                dr.Close();
                dr = cmd.ExecuteReader();

                dr.Read();
                return dr[0].ToString();
            }
            else
            {
                return dr[8].ToString();
            }
            
        }
        public String getUserLevel(String username)
        {
            sql = "select * from User where user_name = '" + username + "';";
            cmd.CommandText = sql;
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr[8].ToString() == "Student")
            {
                sql = "select Administration.User_Level from Administration JOIN Class_Teacher ON Administration.Grade = Class_Teacher.Grade JOIN Student ON (Class_Teacher.Grade = Student.Grade AND Class_Teacher.Class = Student.Class) where Student.User_Name = '" + username + "';";
                cmd.CommandText = sql;
                dr.Close();
                dr = cmd.ExecuteReader();

                dr.Read();
                return dr[0].ToString();
            }
            else
            {
                return dr[8].ToString();
            }

        }

        public MySqlDataReader usrReservChk(String User_Name)
        {
            sql = "SELECT * FROM Login_Details WHERE User_Name = '" + User_Name + "';";
            cmd.CommandText = sql;
            dr.Close();
            dr = cmd.ExecuteReader();
            return dr;
        }

        public int usrAdminChk(String User_Level)
        {
            sql = "SELECT Administration.Number_Of_Copies FROM Administration WHERE User_Level = '" + User_Level + "';";
            cmd.CommandText = sql;
            dr.Close();
            dr = cmd.ExecuteReader();
            dr.Read();
            return Convert.ToInt32(dr[0].ToString());
        }

        public MySqlDataReader BookChk(String title_id)
        {
            sql = "SELECT * FROM library_book_title WHERE title_id = '" + title_id + "';";
            cmd.CommandText = sql;
            dr.Close();
            dr = cmd.ExecuteReader();
            return dr;
        }

      public DataSet  authorSearch (String author)
        {
            sql = "select t1.title_id,t1.title,t1.edition,t5.author_name,t3.catalog_name,t3.subcatalog_name,t1.no_of_books,t1.books_available from library_book_title as t1 join catalog_title as t2 on (t1.title_id = t2.title_id) join catalog as t3 on (t2.catalog_id = t3.subcatalog_id) join author_book as t4 on (t1.title_id = t4.book_title_id) join author as t5 on (t4.author_id = t5.author_id) where t5.author_name like '%" + author + "%' GROUP BY t1.title ORDER BY t1.title;";
          
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds,"std");

            return ds;
            
         

        }

       public DataSet titleSearch(String title)
        {
            sql = "select t1.title_id,t1.title,t1.edition,t5.author_name,t3.catalog_name,t3.subcatalog_name,t1.no_of_books,t1.books_available from library_book_title as t1 join catalog_title as t2 on (t1.title_id = t2.title_id) join catalog as t3 on (t2.catalog_id = t3.subcatalog_id) join author_book as t4 on (t1.title_id = t4.book_title_id) join author as t5 on (t4.author_id = t5.author_id) where t1.title like '%" + title + "%' GROUP BY t1.title ORDER BY t1.title;";
            
          
           MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "std");

            return ds;
        }

       public DataSet catalogSearch(String catalog)
        {

            sql = "select t1.title_id,t1.title,t1.edition,t5.author_name,t3.catalog_name,t3.subcatalog_name,t1.no_of_books,t1.books_available from library_book_title as t1 join catalog_title as t2 on (t1.title_id = t2.title_id) join catalog as t3 on (t2.catalog_id = t3.subcatalog_id) join author_book as t4 on (t1.title_id = t4.book_title_id) join author as t5 on (t4.author_id = t5.author_id) where t3.catalog_name like '%" + catalog + "%' OR t3.subcatalog_name LIKE '%" + catalog + "%' GROUP BY t1.title ORDER BY t1.title;";
            
             MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "std");

            return ds;
        }
        
    }
}
