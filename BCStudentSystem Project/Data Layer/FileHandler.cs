using PRGProject.PresentationLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Team Members
//Dylan , Mphela, Hatlane and Tumelo

namespace PRGProject.Data_Layer
{
    internal class FileHandler
    {
        string path = @"SavedData.txt";


        public List<string> ReadData()
        {
            List<string> listData = new List<string>();

            using (StreamReader read = new StreamReader(path))
            {
                string text;

                while ((text = read.ReadLine()) != null)
                {

                    listData.Add(text);

                }
            }

            return listData;
        }


        public void AddData(List<string> listdata)
        {
            try
            {
                //Get the username and password from the "listdata" parameter given to the method
                string username = listdata[0];
                string password = listdata[1];

                //Puts the username and password into one line/string seperated by a comma
                string userInfo = $"{username},{password}";

                //Create a temporary array with only 1 line capacity because it will only verify one line at execution time
                string[] tempArr = new string[1];

                //Store the name and password into the tempoary array
                tempArr[0] = userInfo;
                File.AppendAllLines(path, tempArr);
                MessageBox.Show("Account Registered");
                Registration regForm = new Registration();  
                regForm.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to file: {ex.Message}");
            }
        }

    }
}
