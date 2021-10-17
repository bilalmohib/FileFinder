using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SELABPROJECT_SEARCHING
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string[] dirs = Directory.GetDirectories(@"E:\Fifth Semester Material\AI Lab\Python\Assignment\Assignment 2 Solving Problem by Searching", "*", SearchOption.TopDirectoryOnly);
                //MessageBox.Show("The number of directories starting with p is {0}.", dirs.Length.ToString());
                //foreach (string dir in dirs)
                //{
                //    MessageBox.Show(dir);
                //}

                //To search within a file
                //string[] dirs = (string[])Directory
                //.EnumerateFiles(@"E:\Upwork Projects Clients\Marcello\WebOffice Tool\src\app\main\pages\profile", "*.jsx")              // all txt files (put the right wildcard)
                //.Where(file => File
                //.ReadLines(file)                            // with at least one line
                //.Any(line => line.Contains("Select the user about which you want to set permissions for pages")))  // which contains stringToFind
                //.ToArray();
                //MessageBox.Show(dirs[0].ToString());


                //string rootdir = @"E:\Upwork Projects Clients\Marcello\WebOffice Tool\src\app\main\pages\profile";
                //string[] files = Directory.GetFileSystemEntries(rootdir, "*", SearchOption.AllDirectories);
                //MessageBox.Show(String.Join(Environment.NewLine, files));

                var textBoxText = textBox1.Text;

                string rootdir = @textBoxText;

                //// print list of files in the root directory and all its subdirectories
                //var files = Directory.EnumerateFiles(rootdir, "*", SearchOption.AllDirectories);
                //MessageBox.Show(String.Join(Environment.NewLine, files));

                // print list of directories and subdirectories
                var dirs = Directory.EnumerateDirectories(rootdir, "*", SearchOption.AllDirectories);
 //             MessageBox.Show(dirs.GetType().Name);
                for (int i = 0; i < dirs.Count(); i++)
                {
                    string str1 = dirs.ElementAt(i);
                    MessageBox.Show("The string is at: "+str1);
                    string[] dirs2 = (string[])Directory
                    .EnumerateFiles(@str1, "*.jsx")              // all txt files (put the right wildcard)
                    .Where(file => File
                    .ReadLines(file)                            // with at least one line
                    .Any(line => line.Contains("Select the user about which you want to set permissions for pages")))  // which contains stringToFind
                    .ToArray();
                    foreach (string dir in dirs2)
                    {
                        MessageBox.Show("The path is found in directory "+dir);
                    }
                    // do your stuff   
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("The process failed: {0}", E.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
