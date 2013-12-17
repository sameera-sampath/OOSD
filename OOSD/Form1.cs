using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOSD
{
    public partial class MainWindow : Form
    {

        private loginWindow logwin;
        private searchWindow searchwin;
        private lendingAndReturningWindow lrwin;
        private reportWindow rpwin;
        private circulationsWindow circwin;
        private catalogeWindow catWin;
        private administrationWindow adminWin;
        private fineAccountWindow fineWin;
        private userAccountWindow userWin;
        private user currentUser;
        public string userName;

        public MainWindow()
        {
            InitializeComponent();
            currentUser = new user();
        }

        public void setCurrentUser(user temp)
        {
            currentUser = temp;
        }

        public user getCurrentUser(user temp)
        {
            return currentUser;
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            this.Enabled = false;
            logwin = new loginWindow(this, userName);
            //MessageBox.Show("Check 1 "+userName);

            if (loginButton.Text == "Log In")
            {
                logwin.Show();
            }
            else if (loginButton.Text == "Log Out")
            {
                this.loginLabel.Text = "Please login to continue";
                this.loginButton.Text = "Log In";
                this.lendReturnButton.Visible = false;
                this.reportsButton.Visible = false;
                this.adminButton.Visible = false;
                this.userAccountButton.Visible = false;
                closeWindows();
                currentUser = null;
                logwin.Close();
            }
            this.Enabled = true;
            //MessageBox.Show(userName);

        }

        public void closeWindows()
        {
            if (userWin != null)
            {
                userWin.Close();
            }
            if (logwin != null)
            {
                logwin.Close();
            }
            if (adminWin != null)
            {
                adminWin.Close();
            }
            if (lrwin != null)
            {
                lrwin.Close();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void changeLoginButton(String name)
        {
            loginButton.Text = name;
        }

        public void changeLoginLabel(String name)
        {
            loginLabel.Text = "You are logged in as " + userName ;
            userName = name;
        }
        
        private void searchButton_Click(object sender, EventArgs e)
        {
            searchwin = new searchWindow(currentUser,this);
            searchwin.Show();
            this.Enabled = false;

        }

        private void lendReturnButton_Click(object sender, EventArgs e)
        {
            lrwin = new lendingAndReturningWindow(this);
            lrwin.Show();
            this.Enabled = false;
        }

        private void circulationButton_Click(object sender, EventArgs e)
        {
            circwin = new circulationsWindow();
            circwin.Show();
        }

        private void reportsBuon_Click(object sender, EventArgs e)
        {
            rpwin = new reportWindow();
            rpwin.Show();
        }

        private void catologButton_Click(object sender, EventArgs e)
        {
            catWin = new catalogeWindow();
            catWin.Show();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            adminWin = new administrationWindow(currentUser,this);
            adminWin.Show();
            this.Enabled = false;

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (loginButton.Text == "LogIn")
            {
            }
        }

        private void fineAccountButton_Click(object sender, EventArgs e)
        {
            fineWin = new fineAccountWindow();
            fineWin.Show();
            this.Enabled = false;
        }

        private void userAccountButton_Click(object sender, EventArgs e)
        {
            userWin = new userAccountWindow(userName, this);
            userWin.Show();
            this.Enabled = false;
        }

        public void changeState()
        {
            this.Enabled = true;
        }

        


    }
}
