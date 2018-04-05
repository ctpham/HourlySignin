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
        private List<CACE> _caces;
        private SortedSet<DateTime> _dateTimeSet;
        private string _filePath;
        private string _projectDirectory;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _importer = new ImportExcel();
            btnRun.Enabled = false;
            _dateTimeSet = new SortedSet<DateTime>();
            _projectDirectory = Directory.GetParent(
                                Directory.GetCurrentDirectory()).Parent.FullName;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            _filePath = _importer.OpenFile();
            txtFileName.Text = " " + Path.GetFileName(_filePath);
            isValidPath();
        }

        //"Main()"
        private void btnRun_Click(object sender, EventArgs e)
        {
            _caces = _importer.QueryData(_filePath);
            createDateTimeSet();

            _caces.Sort();

            List<Week> validWeeks = createValidWeeks();

            List<Week> dataWeeks = fillWeeksWithData(validWeeks);

            totalEachDay(dataWeeks);

            printWeeks(dataWeeks);

            //Debugging
            string outputFile = _projectDirectory + "\\Resources\\output_data.txt";
            printData(outputFile);
        }

        //_dateTimeSet and _caces should be sorted before this is called
        private List<Week> createValidWeeks()
        {
            List<Week> weeks = new List<Week>();
            foreach (DateTime dt in _dateTimeSet)
            {
                //if no week in weeks
                //create new week and add it to list of weeks
                if (!weeks.Any())
                {
                    Week week = new Week();
                    week.SetWeekRange(dt);
                    weeks.Add(week);
                }
                //else check if dt fits in any week
                //if not, add it to a new week
                else
                {
                    bool needAnotherWeek = true;
                    foreach (Week week in weeks)
                    {
                        if (week.FitsInDateRange(dt))
                        {
                            needAnotherWeek = false;
                        }
                    }
                    if (needAnotherWeek)
                    {
                        Week week = new Week();
                        week.SetWeekRange(dt);
                        weeks.Add(week);
                    }
                }
            }
            return weeks;
        }

        private List<Week> fillWeeksWithData(List<Week> validWeeks)
        {
            foreach (CACE cace in _caces)
            {
                foreach (Week validWeek in validWeeks)
                {
                    if (validWeek.FitsInDateRange(cace.DateTime))
                    {
                        validWeek.PutData(cace.DateTime);
                        break;
                    }
                }
            }
            return validWeeks;
        }

        private void totalEachDay(List<Week> dataWeeks)
        {
            foreach (Week week in dataWeeks)
            {
                week.TotalEachDay();
            }
        }

        private void createDateTimeSet()
        {
            foreach (CACE cace in _caces)
            {
                int year = cace.DateTime.Year;
                int month = cace.DateTime.Month;
                int day = cace.DateTime.Day;
                DateTime dt = new DateTime(year, month, day);

                _dateTimeSet.Add(dt);
            }
        }

        private void isValidPath()
        {
            Path.GetFullPath(_filePath);
            //if exception is not thrown:
            btnRun.Enabled = true;
        }

        //To debug output
        private void printData(string outputFile)
        {
            using (TextWriter tw = new StreamWriter(outputFile))
            {
                foreach (CACE cace in _caces)
                    tw.WriteLine(cace.ToString());
            }
        }
        
        private void printWeeks(List<Week> weeks)
        {
            foreach (Week week in weeks)
            {
                week.Print();
            }
        }
    }
}
