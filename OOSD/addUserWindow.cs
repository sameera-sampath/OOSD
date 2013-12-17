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
    public partial class addUserWindow : Form
    {
        private String defaultPasswrd = "libUsr";
        private user newUser;
        private administrationWindow addWin;
        public DateTime Now;
        private adminDatabaseHandler adminHandle;

        public addUserWindow(administrationWindow temp)
        {
            InitializeComponent();
            newUser = new user();
            Now = new DateTime();
            addWin = temp;
            adminHandle = new adminDatabaseHandler();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if(firstNameBox.Text == "")
            {
                MessageBox.Show("First Name is required!");
            }
            if (lastNameBox.Text == "")
            {
                MessageBox.Show("Last Name is required!");
            }
            if (userTypeCombo.SelectedText == "")
            {
                MessageBox.Show("User type is required!");
            }
            if (firstNameBox.Text == "")
            {
                MessageBox.Show("Name is required!");
            }

            creatUser();
            adminHandle.addUser(newUser);

        }

        public void creatUser()
        {
            newUser.setCity(cityBox.Text);
            newUser.setClass(classBox.Text);
            newUser.setemail(emailBox.Text);
            //newUser.setEmail();
            newUser.setFirstName(firstNameBox.Text);
            newUser.setGrade(gradeSelectionBox.SelectedText);
            newUser.sethomeTelephone(homeTelephoneBox.Text);
            //newUser.setindexNo();
            newUser.setLastName(lastNameBox.Text);
            newUser.setMiddleName(middleNameBox.Text);
            newUser.setmobile(mobileBox.Text);
            newUser.setpassword(defaultPasswrd);
            //newUser.setPassword();
            newUser.setPostalCode(postalCodeBox.Text);
            newUser.setPostalNo(postalNoBox.Text);
            newUser.setregisteredDate(Now.Date);
            //newUser.setregistrationNumber();              //**//
            newUser.setRoot(rootBox.Text);
            //newUser.setuserState();
            //newUser.setUserState();
            newUser.setuserType(userTypeCombo.SelectedText);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            addWin.Enabled = true;
            base.OnFormClosing(e);
        }

        private void userTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userTypeCombo.SelectedIndex == 4)
            {
                groupBox4.Enabled = true;
            }
            else
                groupBox4.Enabled = false;
        }
    }
}
