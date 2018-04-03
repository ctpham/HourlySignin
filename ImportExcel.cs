using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using System.IO;
using System.Windows.Forms;

namespace HourlySign
{
    class ImportExcel
    {
        private ExcelQueryFactory _sheet;

        public ImportExcel() { }

        public List<CACE> QueryData(string fileName)
        {
            _sheet = new ExcelQueryFactory(fileName);
            var rows = from c in _sheet.WorksheetNoHeader()
                       select c;
            List<CACE> caces = new List<CACE>();

            foreach(var row in rows)
            {
                CACE cace = new CACE(row[0], row[1], row[2], row[3], row[4]);
                caces.Add(cace);
            }

            return caces;
        }

        public string OpenFile()
        {
            string selectedFile = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Filter = "Excel files |*.xlsx; *.csv; *.xls";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFile = openFileDialog1.FileName;
            }
            return selectedFile;
        }
    }
}
