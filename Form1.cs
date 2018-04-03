using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HourlySign

     //public System.IO.Stream OpenFile();
{
     public partial class Form1 : Form
     {
          public static string SelectedFile;

        private ImportExcel _importer;

          public Form1()
          {
               InitializeComponent();
               _importer = new ImportExcel();
          
          }

        private void button1_Click(object sender, EventArgs e)
        {
            List <CACE> caces = _importer.QueryData();
               int a = 0; // for debug
        }

          private void Form1_Load(object sender, EventArgs e)
          {

          }


          private void button2_Click(object sender, EventArgs e)
          {

               Stream myStream = null;
               OpenFileDialog openFileDialog1 = new OpenFileDialog();

               openFileDialog1.InitialDirectory = "c:\\";
               openFileDialog1.Filter = "Excel files |*.xlsx";
               openFileDialog1.FilterIndex = 2;
               openFileDialog1.RestoreDirectory = true;

               if (openFileDialog1.ShowDialog() == DialogResult.OK)
               {
                    SelectedFile = openFileDialog1.FileName;
                    try
                    {
                         if ((myStream = openFileDialog1.OpenFile()) != null)
                         {
                              using (myStream)
                              {
                                   // Insert code to read the stream here.
                                   //SelectedFile = openFileDialog1.FileName;
                              }
                         }
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
               }
          }
     }
     
}
