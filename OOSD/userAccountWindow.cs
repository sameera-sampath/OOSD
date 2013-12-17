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
    public partial class userAccountWindow : Form
    {
        private user currentuser;
        //private checkValidEmail check;
        private passwordChangeWindow psWin;
        private viewReservationsWindow resWin;
        private emailChangeWindow emailWin;
        private borrowHistoryWindow borroWin;
        private MainWindow mWin;
        private string userName;

        public userAccountWindow(string username, MainWindow tempWin)
        {
            
            InitializeComponent();
            mWin = tempWin;
            userName = username;
            
        }

        public bool IsValidEmail(string email)
        {
            return true;
        }

        private void viewReservationsButton_Click(object sender, EventArgs e)
        {
            resWin = new viewReservationsWindow(userName, this);
            resWin.Show();
            this.Enabled = false;
        }

        private void borrowHistryButton_Click(object sender, EventArgs e)
        {
            borroWin = new borrowHistoryWindow(userName, this);
            borroWin.Show();
            this.Enabled = false;
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            emailWin = new emailChangeWindow(userName, this);
            emailWin.Show();
            this.Enabled = false;
        }

        private void passwordButton_Click(object sender, EventArgs e)
        {
            psWin = new passwordChangeWindow(userName, this);
            psWin.Show();
            this.Enabled = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            mWin.Enabled = true;
            base.OnFormClosing(e);
        }
    }
}
