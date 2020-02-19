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

        // Declare a StreamWriter object with OVERWRITING option
        StreamWriter outFileA = new StreamWriter(@"D:\Data\AttendanceA.txt");

        // Declare a StreamWriter object with APPENDING option
        StreamWriter outFile = new StreamWriter(@"D:\Data\Attendance.txt", true);
        private void btnAttemdamce_Click(object sender, EventArgs e)
        {
            //If outFile is closed, renew it.
            if (outFile.BaseStream == null)
            {
                outFile = File.AppendText(@"D:\Data\Attendance.txt");
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
            ////"D:\Data\AttendanceA.txt" is a string literal
            ////@"D:\Data\AttendanceA.txt" verbatim string
            //outFile = File.AppendText(@"D:\Data\Attendance.txt");
        }

        // BTN Done with Attendance
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

        // BTN Hello World
        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            try
            {
                // StreamWriter outHelloFile = new StreamWriter(@":U\Data\AttendanceA.txt");
                StreamWriter outHelloFile;
                outHelloFile = File.AppendText(@":D\Data\HelloWorld.txt");
                outHelloFile.Write("Hello World!");
                outHelloFile.Close();
                MessageBox.Show(@"The file D:\Data\HelloWorld.txt is saved.");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        // BTN write line 
        private void btnWriteOrWriteLine_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outFile = new StreamWriter(@"D:\Data\Test.txt");
                //StreamWriter outFile;
                //outFile = File.CreateText(@"U:\Data\Test.txt");
                outFile.WriteLine("Line one.");
                outFile.Write("Line Two.");
                outFile.WriteLine("Line two continued.");
                outFile.Write("Last Line.");
                outFile.WriteLine("Line line continued.");
                outFile.Write("Actually, this is the Last Line.");
                outFile.Close();
            }
            catch (EncoderFallbackException exEnc)
            {
                MessageBox.Show(exEnc.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // BTN Number list
        private void btnNumberList_Click(object sender, EventArgs e)
        {
            StreamWriter numberList;
            numberList = File.CreateText(@"D:\DataNumberlist.txt");
            for (int x = 0; x <= 100; x++)
            {
                numberList.WriteLine(x.ToString());
                numberList.Write(x.ToString() + Environment.NewLine);
                numberList.Close();
                MessageBox.Show(@"Text file numberlist.txt is created in D:\Data folder.");
            }
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Title = "Chose a path and type the file name.";
            sd.InitialDirectory = @"U:\data";
            sd.FileName = @"U:\data\newfile.txt"; // if suggesting a file name
            sd.Filter = "text files(*.txt)|*.txt|Add files(*.*)|*.*";
            DialogResult x = sd.ShowDialog();
            if (x == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(sd.FileName);
                    sw.Write(txtMessage.Text);
                    sw.Close();
                    MessageBox.Show(sd.FileName + " has been saved.");
                } 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}


