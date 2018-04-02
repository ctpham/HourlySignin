using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;

namespace HourlySign
{
    class ImportExcel
    {
        private ExcelQueryFactory _sheet;

        public ImportExcel()
        {
            //TODO: specify path to file
            //add as parameter to constructor
            _sheet = new ExcelQueryFactory(@"C:\Users\TEST\Desktop\CACE Numbers.xlsx");
        }

        public List<CACE> QueryData()
        {
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
    }
}
