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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string user_n = email.Text;
            string p = password.Text;

            if(user_n == "bilal@gmail.com" && p == "uetse")
            {
                MessageBox.Show("Login Successful");
                Main main = new Main(); //this is the change, code for redirect  
                main.Show();
            }
            else
            {
                MessageBox.Show("Wrong Email or Password!");
            }
        }
    }
}
