using PRGProject.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRGProject.PresentationLayer
{
    public partial class Modules : Form
    {
        DataHandler handler = new DataHandler();
        public Modules()
        {
            InitializeComponent();
        }

        private void mdlldisplaybtn_Click(object sender, EventArgs e)
        {
            dataGridViewModule.DataSource = null;
           dataGridViewModule.DataSource =  handler.ALLModuleData();
        }

        private void Modules_Load(object sender, EventArgs e)
        {
            dataGridViewModule.DataSource = handler.ALLModuleData();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Main main = new Main(); 
            main.Show();
            this.Close();

        }

        private void ModuleAdd_Click(object sender, EventArgs e)
        {
            Module mod = new Module(int.Parse(mcodeBox.Text) ,mNamebox.Text,mDescriptionbox.Text, mLinksbox.Text);

            handler.AddModule(mod);
            MessageBox.Show("Module Successfully Added");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Module mod = new Module(int.Parse(mcodeBox.Text), mNamebox.Text, mDescriptionbox.Text, mLinksbox.Text);

            handler.UpdateModule(mod);
            MessageBox.Show("Module Successfully Updated");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            handler.DeleteModule(int.Parse(mcodeBox.Text));
            MessageBox.Show("Delete Successful");
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
           dataGridViewModule.DataSource = handler.SearchModule(int.Parse(searchtxt.Text));
        }

        private void dataGridViewModule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewModule.DataSource = handler.ALLModuleData();
        }
    }
}
