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
    public partial class suspendUserWindow : Form
    {
        private administrationWindow addWin;
        private adminDatabaseHandler adminhandle;

        public suspendUserWindow(administrationWindow temp)
        {
            InitializeComponent();
            addWin = temp;
            adminhandle = new adminDatabaseHandler();
        }

        private void suspendUserWindow_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            addWin.Enabled = true;
            base.OnFormClosing(e);
        }

        private void removeUser_Click(object sender, EventArgs e)
        {
            string username = removeUserText.Text;
            string tempduration = durationBox.SelectedText;
            adminhandle.suspendUser(username, Convert.ToInt32(tempduration));

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
