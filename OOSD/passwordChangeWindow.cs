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
    public partial class passwordChangeWindow : Form
    {
        private userAccountWindow userWin;
        Connection connection;
        private string userName;

        public passwordChangeWindow(string username, userAccountWindow temp)
        {
            InitializeComponent();
            userWin = temp;
            connection  = new Connection();
            userName = username;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Check 4 " + userName);
            string currentPassword = currentPasswordBox.Text;
            string newpassword1 = newPasswordBox1.Text;
            string newpassword2 = newPasswordBox2.Text;
            currentPasswordBox.Text = "";
            newPasswordBox1.Text = "";
            newPasswordBox2.Text = "";
            connection.changeUserPassword(userName, currentPassword, newpassword1, newpassword2);
            this.Close();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            userWin.Enabled = true;
            base.OnFormClosing(e);
        }
    }
}
