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
        private string _filePath;
        List<CACE> _caces;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _importer = new ImportExcel();
            btnLoadData.Enabled = false;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            _filePath = _importer.OpenFile();
            txtFileName.Text = " " + Path.GetFileName(_filePath);
            isValidPath();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            _caces = _importer.QueryData(_filePath);
        }

        private void isValidPath() 
        {
            Path.GetFullPath(_filePath);
            //if exception is not thrown:
            btnLoadData.Enabled = true;
        }
    }
}
