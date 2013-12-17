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
    public partial class administrationWindow : Form
    {
        private user currentuser;
        private MainWindow mWin;
        private addUserWindow addWin;
        private suspendUserWindow susWin;
        private removeUserWindow remWin;
        private passwordResetWindow passWin;

        public administrationWindow(user temp, MainWindow tempWin)
        {
            InitializeComponent();
            currentuser = temp;
            mWin = tempWin;
        }
    
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            mWin.Enabled = true;
            base.OnFormClosing(e);
        }

        private void d_Click(object sender, EventArgs e)
        {
            addWin = new addUserWindow(this);
            addWin.Show();
            this.Enabled = false;
        }

        private void suspendUserButton_Click(object sender, EventArgs e)
        {
            susWin = new suspendUserWindow(this);
            susWin.Show();
            this.Enabled = false;
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            remWin = new removeUserWindow(this);
            remWin.Show();
            this.Enabled = false;
        }

        private void passwordResetButton_Click(object sender, EventArgs e)
        {
            passWin = new passwordResetWindow(this);
            passWin.Show();
            this.Enabled = false;
        }

    }
}
