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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Main main = new Main(); //this is the change, code for redirect  
            main.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            View main = new View(); //this is the change, code for redirect  
            main.Show();
        }
    }
}
