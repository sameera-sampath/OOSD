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
    public partial class removeUserWindow : Form
    {
        private administrationWindow addwin;
        private adminDatabaseHandler adminhandle;


        public removeUserWindow(administrationWindow temp)
        {
            InitializeComponent();
            addwin = temp;
            adminhandle = new adminDatabaseHandler();
        }

        private void removeUser_Click(object sender, EventArgs e)
        {
            string username = removeUserText.Text;
            adminhandle.removeUser(username);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            addwin.Enabled = true;
            base.OnFormClosing(e);
        }
    }
}
