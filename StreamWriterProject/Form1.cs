using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Added for the StreamWriter

namespace StreamWriterProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Declare a StreamWriter object with overwriting option
        StreamWriter outFileA = new StreamWriter(@"U:\Data\AttendanceA.txt");

        // Declare a StreamWriter object with appending option
        StreamWriter outFile = new StreamWriter(@"U:\Data\Attendance.txt", true);
        private void btnAttemdamce_Click(object sender, EventArgs e)
        {
            //If outFile is closed, renew it.
            if (outFile.BaseStream == null)
            {
                outFile = File.AppendText(@"U:\Data\Attendance.txt");
            }
            try
            {
                outFile.WriteLine(txtName.Text);
                //outFile.Write(txtMessage.)           New line...
                MessageBox.Show(txtName.Text + " is on attendance list now.");
		        txtName.Focus(); //the control receives focus
                // User's previous input is selected for easy typing over 
                txtName.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //outFileA = File.CreateText(@":U\Data\AttendanceA.txt");
            ////"U:\Data\AttendanceA.txt" is a string literal
            ////@"W:\Data\AttendanceA.txt" verbatim string
            //outFile = File.AppendText(@"U:\Data\Attendance.txt");
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            try
            {
                // StreamWriter outHelloFile = new StreamWriter(@":U\Data\AttendanceA.txt");
                StreamWriter outHelloFile;
                outHelloFile = File.AppendText(@":U\Data\AttendanceA.txt");
                outHelloFile.Write("Hello World!");
                outHelloFile.Close();
                MessageBox.Show(@"The file U:\Data\HelloWorld.txt is saved.");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnDoneWithAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                outFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


