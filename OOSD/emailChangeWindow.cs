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
    public partial class emailChangeWindow : Form
    {
        private userAccountWindow userWin;
        Connection connection;
        private string userName;

        public emailChangeWindow(string username,userAccountWindow temp)
        {
            InitializeComponent();
            userWin = temp;
            connection = new Connection();
            userName = username;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            userWin.Enabled = true;
            base.OnFormClosing(e);
        }

        private void changeEmailButton_Click(object sender, EventArgs e)
        {
            string pssword = currentPasswordBox.Text;
            string newEmail = emailBox.Text;
            connection.changeUserEmail(userName, pssword, newEmail);
        }
    }
}
