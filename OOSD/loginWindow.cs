using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OOSD
{
    public partial class loginWindow : Form
    {       //user interface for user login
        private String username;
        private MainWindow tempForm1;
        private String logState;
        private userLoginHandler loginHanler;
        private string userName;

        public loginWindow(MainWindow frm1,string username)
        {
            InitializeComponent();
            tempForm1 = frm1;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginHanler = new userLoginHandler();
            Boolean check = false;
            try
            {
                check = loginHanler.userVerification(indexNoBox.Text, passwordBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Index No. Format" + ex.ToString());
            }
            //MessageBox.Show(check.ToString());
            if (check != false)
            {
                //MessageBox.Show("in 4 things");
                username = indexNoBox.Text;
                logState = loginHanler.usertype(username);
                MessageBox.Show("Login Successful " + logState + "");
                tempForm1.userAccountButton.Visible = true;
                userName = indexNoBox.Text;
                tempForm1.userName = this.userName;
                switch (logState)
                {
                    case "Library_Staff":
                    case "Principal":
                        tempForm1.lendReturnButton.Visible = true;
                        tempForm1.reportsButton.Visible = true;
                        tempForm1.adminButton.Visible = true;
                        break;
                    case "Teacher":
                        tempForm1.reportsButton.Visible = true;
                        break;
                }
              /*if (loginHanler.usertype(indexNoBox.Text) == "Library_Staff")
                {
                    userName = indexNoBox.Text;
                    tempForm1.userName = this.userName;
                    MessageBox.Show("Login Successful ( Library_Staff )");
                    logState = "Admin";
                    tempForm1.lendReturnButton.Visible = true;
                    tempForm1.reportsButton.Visible = true;
                    tempForm1.adminButton.Visible = true;
                    tempForm1.userAccountButton.Visible = true;
                }
                else if (loginHanler.usertype(indexNoBox.Text) == "Principal")
                {
                    MessageBox.Show("Login Successful ( principal )");
                    logState = "Staff";
                    tempForm1.reportsButton.Visible = true;
                    tempForm1.adminButton.Visible = true;
                    tempForm1.lendReturnButton.Visible = true;
                    tempForm1.userAccountButton.Visible = true;
                }
                else if (loginHanler.usertype(indexNoBox.Text) == "Student")
                {
                    MessageBox.Show("Login Successful ( Student )");
                    logState = "Student";
                    tempForm1.reportsButton.Visible = false;
                    tempForm1.adminButton.Visible = false;
                    tempForm1.lendReturnButton.Visible = false;
                    tempForm1.reportsButton.Visible = false;
                }*/

                tempForm1.userAccountButton.Enabled = true;
                tempForm1.changeLoginButton("Log Out");
                tempForm1.changeLoginLabel(username);
                this.Hide();
                tempForm1.Enabled = true;
            }
            else
            {
                MessageBox.Show("wrong username or password");
                indexNoBox.Text = "";
                passwordBox.Text = "";
                this.Close();
            }


        }

        public String getUsername()
        {
            return username;
        }

        public void resetUsername()
        {
            username = "";
            indexNoBox.Text = "";
            passwordBox.Text = "";
        }

        public String getLoginStatus()
        {
            return logState;
        }

        private void loginWindow_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            tempForm1.Enabled = true;
            base.OnFormClosing(e);
        }

    }
}
