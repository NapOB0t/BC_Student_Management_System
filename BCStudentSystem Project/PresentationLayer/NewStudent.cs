using PRGProject.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PRGProject.DataLayer;
using PRGProject.PresentationLayer;

namespace PRGProject.PresentationLayer
{
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
        }
        DataHandler handler = new DataHandler();
        private void addstudentbtn_Click(object sender, EventArgs e)
        {
            Student student = new Student(int.Parse(studentnumbertxt.Text), nametxt.Text, surnametxt.Text, dobtxt.MaxDate, addresstxt.Text, phonetxt.Text, int.Parse(moduletxt.Text), genderBox.Text);
            handler.ADDStudent(student);
            MessageBox.Show("Student has been added");//call update method
            this.Close();
            
        }

        private void genderBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Student student = new Student(int.Parse(studentnumbertxt.Text), nametxt.Text, surnametxt.Text, dobtxt.MaxDate, addresstxt.Text, phonetxt.Text, int.Parse(moduletxt.Text), genderBox.Text);
            handler.UpdateStudent(student);
            MessageBox.Show("Student Data has been Updated");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            handler.DeleteStudent(int.Parse(studentnumbertxt.Text));
            MessageBox.Show("Student Succesfully Deleted");
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            
        }

        private void studentimg_Click(object sender, EventArgs e)
        {
           
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Main main  = new Main();
            main.Show();
            this.Close();

        }
    }
}
