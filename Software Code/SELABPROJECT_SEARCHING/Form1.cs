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

                var path = textBox1.Text;

                string rootdir = @path;

                //// print list of files in the root directory and all its subdirectories
                //var files = Directory.EnumerateFiles(rootdir, "*", SearchOption.AllDirectories);
                //MessageBox.Show(String.Join(Environment.NewLine, files));

                //The text to be searched
                string txtToSearch = textBox2.Text;

                //File extension which files to search
                string fileExtension = "*." + textBox3.Text;

                if(textBox3.Text == "pdf")
                {
                    MessageBox.Show("Sorry! For now This project is only workable except pdf files.I will implement search for pdf later.");
                    return;
                }

                ////Node modules searching is unecessary so no need to enter the paths of searching nodemodules.Development is not implemented there
                //if (path.Contains("node_modules") == true)
                //{
                //    MessageBox.Show("No need to enter this unecessary path.");
                //    return;
                //}        

                if (path == "" || txtToSearch == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Please fill all the fields to search");
                    return;
                }

                // Not needed yet
                // print list of directories and subdirectories
                var dirs = Directory.EnumerateDirectories(rootdir, "*", SearchOption.AllDirectories);
                //             MessageBox.Show(dirs.GetType().Name);

                if (dirs.Count() == 0)
                {
                    MessageBox.Show("Sorry! Please provide a path where there are directories present.No Directories Found at the given path : " + path);
                    return;
                }
                int check = 0;
                for (int i = 0; i < dirs.Count(); i++)
                {
                    //Saving every value of the enumeration in the variable straight_path
                    string straight_path = dirs.ElementAt(i);

                    //Node modules searching is unecessary so no need to enter the paths of searching nodemodules.Development is not implemented there
                    if (straight_path.Contains("node_modules") == true)
                    {
                        MessageBox.Show("No need to enter this unecessary path. i.e this path : " + straight_path);
                        continue;
                    }

                    MessageBox.Show("Searching at path: " + straight_path);
                    searchtxt.Text = "Searching at path: " + straight_path;
                    string[] dirs2 = (string[])Directory
                    .EnumerateFiles(@straight_path, fileExtension)              // all txt files (put the right wildcard)
                    .Where(file => File
                    .ReadLines(file)                            // with at least one line
                    .Any(line => line.Contains(txtToSearch)))  // which contains stringToFind
                    .ToArray();

                    if (dirs2.Count() == 0)
                    {
                        ++check;
                    }

                    foreach (string dir in dirs2)
                    {
                        MessageBox.Show("Congrats! The File is found in directory " + "\n" + dir);
                        return;
                    }
                    // do your stuff   
                }
                if ((check - 1) == dirs.Count())
                {
                    MessageBox.Show("Sorry No files found with extension :" + fileExtension + ". \nPlease enter a file extension of files present in the provided path " + path);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Error! Text Not Found or no file found with entered extension.", E.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
