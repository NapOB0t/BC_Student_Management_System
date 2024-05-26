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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        DataHandler handler = new DataHandler();
        private void viewbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.ALLStudentData();//will call method to show all the data
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            handler.DeleteStudent(int.Parse(Searchtxt.Text));
            MessageBox.Show($"Student {Searchtxt.Text} has been deleted");
        }


        private void Searchbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.SearchStudent(int.Parse(Searchtxt.Text));
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modules modulesfrm = new Modules();
            modulesfrm.Show();
            this.Close();
        }

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            NewStudent createfrm = new NewStudent();
            createfrm.Show();
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.ALLStudentData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
