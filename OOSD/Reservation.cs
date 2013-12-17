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
    public partial class Reservation : Form
    {
        int resrv, userbook, book, issued, alowed;
        string user;
        String userLevel;
        String levelUser;
        Connection connection;
        IDataReader dr;
        public Reservation(string userName)
        {
            user = userName;
            connection = new Connection();
            userLevel = connection.getUserLevel(user);
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            if (userLevel == "Library_Staff")
            {
                user_label.Visible = true;
                user_text.Visible = true;
            }
            else
            {
                user_text.Text = user;
            }
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            if (userLevel == "Library_Staff")
            {
                levelUser = connection.getUserState(user_text.Text);
            }
            else
            {
                levelUser = userLevel;
            }
            alowed = connection.usrAdminChk(levelUser);
            dr = connection.usrReservChk(user_text.Text);
            dr.Read();
            userbook=Convert.ToInt32(dr[5].ToString());
            resrv=Convert.ToInt32(dr[6].ToString());

            dr = connection.BookChk(title_text.Text);
            dr.Read();
            book = Convert.ToInt32(dr[3].ToString());
            issued = Convert.ToInt32(dr[4].ToString());
            if (resrv + userbook <= alowed)
            {
                if (book == issued)
                {
                    connection.setReserv(user_text.Text, title_text.Text);
                    MessageBox.Show("Book is reserved.");
                }
                else
                {
                    MessageBox.Show("Book is available in the library");
                }
            }
            else
            {
                MessageBox.Show("User can't reserve any more books");
            }
        }
    }
}
