using PRGProject.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRGProject.DataLayer;
using PRGProject.BusinessLogicLayer;


namespace PRGProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text, password = passwordtxt.Text;
            Operations operations = new Operations();
            if (username != "" && password != "")
            {
                if (operations.ValidateUserLogin(username, password))
                {

                    Main mainMenuForm = new Main();

                    this.Hide();

                    mainMenuForm.Show();

                }
                else
                {

                    MessageBox.Show("Your password is incorrect or your account does not exist");
                }
            }
            else
            {
                MessageBox.Show("Please make sure to enter all the information");
            }
        }



        private void Register_Click(object sender, EventArgs e)
        {
            Registration regfrm = new Registration();//this will fetch the registration form
            this.Hide();//this will close the login form
            regfrm.Show();
           
        }
    }
}


