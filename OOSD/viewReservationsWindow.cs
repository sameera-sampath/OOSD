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
    public partial class viewReservationsWindow : Form
    {
        private userAccountWindow userWin;
        private user currentUser;
        private Connection connection;
        private string userName;

        public viewReservationsWindow(string username, userAccountWindow temp)
        {
            InitializeComponent();
            userWin = temp;
            userName = username;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            userWin.Enabled = true;
            base.OnFormClosing(e);
        }

        private void viewReservationsWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
