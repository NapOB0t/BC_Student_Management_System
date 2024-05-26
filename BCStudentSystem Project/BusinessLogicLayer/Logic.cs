using PRGProject.Data_Layer;
using PRGProject.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

//Team Members
//Dylan , Mphela, Hatlane and Tumelo

namespace PRGProject.BusinessLogicLayer
{
    internal class Operations

    {

        FileHandler handler = new FileHandler();
        //Method for validating password and username infomration
      
        
            //Method for validating password and username infomration
            public bool Validation(string user, string pass)
            {
                string usernamePattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+$";
                string passwordPattern = @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";

                Regex usernameRegex = new Regex(usernamePattern);
                bool usernameMatch = usernameRegex.IsMatch(user);

                Regex passwordRegex = new Regex(passwordPattern);
                bool passwordMatch = passwordRegex.IsMatch(pass);

                return usernameMatch && passwordMatch;
            }
            public bool ValidateRegistration(string accountName, string password1, string password2)
            {
                // Check if the username and passwords are not empty
                if (string.IsNullOrWhiteSpace(accountName) || string.IsNullOrWhiteSpace(password1) || string.IsNullOrWhiteSpace(password2))
                {
                    MessageBox.Show("ALERT: Username and password cannot be empty");
                    return false;
                }

                // Check if the passwords match
                if (!password1.Equals(password2))
                {
                    MessageBox.Show("ALERT: The passwords do not match");
                    return false;
                }

                return true; // Registration is valid
            }
            public bool ValidateCredentials(string enteredUsername, string enteredPassword, string storedUsername, string storedPassword)
            {
                return enteredUsername.Equals(storedUsername, StringComparison.OrdinalIgnoreCase) && enteredPassword.Equals(storedPassword);
            }

            public Boolean ValidateUserLogin(string name, string password)
            {
                bool access = false;

                FileHandler handler = new FileHandler();
                List<String> lecturerList = handler.ReadData();

                if (lecturerList != null)
                {
                    foreach (var item in lecturerList)
                    {
                        string[] tempArr = item.Split(',');

                        if (name == tempArr[0] && password == tempArr[1])
                        {
                            access = true;
                            break;
                        }
                    }
                }
                return access;
            }
        }


    }

