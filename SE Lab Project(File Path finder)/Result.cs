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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            Path.Text = Main.SetValueForText1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening the path " + Path.Text);
            System.Diagnostics.Process.Start(Path.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Main main = new Main(); //this is the change, code for redirect  
            main.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
