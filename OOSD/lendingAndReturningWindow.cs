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
    public partial class lendingAndReturningWindow : Form
    {
        private MainWindow mWin;
        Connection connection;

        public lendingAndReturningWindow(MainWindow temp)
        {
            InitializeComponent();
            mWin = temp;
            connection = new Connection();
        }

        private void lendButton_Click(object sender, EventArgs e)
        {
            DateTime due = connection.lendBook(lendBookIDBox.Text,lendUserIDBox.Text,DateTime.Now);
            lendBookIDBox.Text = "";
            lendUserIDBox.Text = "";
        }

        private void lendUserIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            mWin.Enabled = true;
            base.OnFormClosing(e);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            DateTime today = new DateTime();
            DateTime due = connection.returnBook(returnBookIDBox.Text, returnUserIDBox.Text, DateTime.Now);
            if (DateTime.Compare(due,today)<=0)
            {
                TimeSpan diff = today - due;

            }
            returnBookIDBox.Text = "";
            returnUserIDBox.Text = "";
        }


    }
}
