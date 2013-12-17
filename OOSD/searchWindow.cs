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
    public partial class searchWindow : Form
    {
        private Reservation resWin;
        private MainWindow mWin;
        private user currentUser;
        private searchingHandler searchHandle;

        public searchWindow(user tempuser,MainWindow temp)
        {
            InitializeComponent();
            mWin = temp;
            currentUser = tempuser;
            searchHandle = new searchingHandler();
        }

        private void searchWindow_Load(object sender, EventArgs e)
        {
            if (mWin.userName != null)
            {
                this.reserveButton.Visible= true;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            mWin.Enabled = true;
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataSet searchData = null;
            searchTable.DataSource = searchData;
            searchTable.DataMember = "std";
            searchTable.Refresh();
            string title = titleBox.Text;
            string author = authorBox.Text;
            string catalog = catalogBox.Text;
            searchData = searchHandle.search(title,author,catalog);

            searchTable.DataSource = searchData;
            searchTable.DataMember = "std";
            searchTable.Refresh();
            reserveButton.Enabled = true;
            clearButton.Enabled = true;

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            mWin.Enabled = true;
            base.OnFormClosing(e);
        }

        private void searchTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            resWin = new Reservation(mWin.userName);
            resWin.Show();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            authorBox.Text = "";
            catalogBox.Text = "";
            DataSet searchData = null;
            searchTable.DataSource = searchData;
            searchTable.DataMember = "std";
            searchTable.Refresh();
            reserveButton.Enabled = false;
        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {
            authorBox.Text = "";
            catalogBox.Text = "";
        }
        private void authorBox_TextChanged(object sender, EventArgs e)
        {
            titleBox.Text = "";
            catalogBox.Text = "";
        }
        private void catalogBox_TextChanged(object sender, EventArgs e)
        {
            authorBox.Text = "";
            titleBox.Text = "";
        }

    }
}
