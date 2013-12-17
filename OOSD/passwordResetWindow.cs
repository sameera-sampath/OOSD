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
    public partial class passwordResetWindow : Form
    {
        private administrationWindow addWin;
        private String defaultPasswrd = "libUsr";
        private adminDatabaseHandler adminhandle;

        public passwordResetWindow(administrationWindow temp)
        {
            InitializeComponent();
            addWin = temp;
            adminhandle = new adminDatabaseHandler();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            string username = userIDBox.Text;
            string password = newPasswordBox1.Text;
            adminhandle.resetPassword(username, password);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            addWin.Enabled = true;
            base.OnFormClosing(e);
        }
    }
}
