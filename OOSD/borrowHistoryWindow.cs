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
    public partial class borrowHistoryWindow : Form
    {
        private userAccountWindow mWin;
        private user currentUser;
        private Connection connection;
        private string userName;

        public borrowHistoryWindow(string username, userAccountWindow temp)
        {
            InitializeComponent();
            mWin = temp;
            connection = new Connection();
            userName = username;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mWin.Enabled = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            mWin.Enabled = true;
            base.OnFormClosing(e);
        }

        private void borrowHistoryWindow_Load(object sender, EventArgs e)
        {
            connection.getReservations(userName);
        }



    }
}
