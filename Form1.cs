using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HourlySign
{
     public partial class Form1 : Form
     {
        private ImportExcel _importer;

          public Form1()
          {
               InitializeComponent();
               _importer = new ImportExcel();
          }

        private void button1_Click(object sender, EventArgs e)
        {
            List <CACE> caces = _importer.QueryData();
        }
    }
}
