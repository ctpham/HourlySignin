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
{
    public partial class Form1 : Form
    {
        private ImportExcel _importer;
        private string _fileName;

        public Form1()
        {
            InitializeComponent();
            _importer = new ImportExcel();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List <CACE> caces = _importer.QueryData(_fileName);
            int a = 0; // for debug
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _fileName = _importer.OpenFile();
        }
    }
}
