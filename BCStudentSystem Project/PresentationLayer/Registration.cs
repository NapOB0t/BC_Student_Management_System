using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRGProject.PresentationLayer;
using PRGProject.DataLayer;
using PRGProject.BusinessLogicLayer;
using PRGProject.Data_Layer;


namespace PRGProject.PresentationLayer
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
       // FileHandler Handler = new FileHandler();    
           


        private void registerbtn_Click(object sender, EventArgs e)
        {
            string accountName, password1, password2;
            Operations operations = new Operations();
            FileHandler datahandler = new FileHandler();

            List<string> listdata = new List<string>();

            accountName = textBox1.Text;
            password1 = textBox2.Text;
            password2 = textBox3.Text;


            if (operations.ValidateRegistration(accountName, password1, password2))
            {
                List<string> dataList = new List<string>();
                dataList.Add(accountName);
                dataList.Add(password1);


                datahandler.AddData(dataList);

               

                LoginForm loginfrms = new LoginForm();
                loginfrms.Show();
                this.Close();
                MessageBox.Show("Registration was successful");//add if statement for it to only show once the username and password are validated

            }
            else
            {
                MessageBox.Show("ALERT: The passwords do not match");
            }
            //add validation for it to continue to the login page
            MessageBox.Show("Registration was successful");//add if statement for it to only show once the username and password are validated
            
            
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {


            LoginForm loginfrm = new LoginForm();
            loginfrm.Show();
            this.Close();
        }
    }
}
