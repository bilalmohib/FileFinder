using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Lab_Project_File_Path_finder_
{
    public partial class start_screen : Form
    {
        public start_screen()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {   
            Login l1 = new Login(); //this is the change, code for redirect  
            l1.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Start_screen_Load(object sender, EventArgs e)
        {

        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Help l1 = new Help(); //this is the change, code for redirect  
            l1.Show();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Login l1 = new Login(); //this is the change, code for redirect  
            l1.Show();
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin l1 = new Admin(); //this is the change, code for redirect  
            l1.Show();
        }
    }
}
