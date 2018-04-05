using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//HourlyTimeframe[0][x] is between 9:00-9:59 AM
//HourlyTimeframe[1][x] is between 10:00-10:59 AM
//HourlyTimeframe[2][x] is between 11:00-11:59 AM
//HourlyTimeframe[3][x] is between 12:00-12:59 PM
//HourlyTimeframe[4][x] is between 1:00-1:59 PM
//HourlyTimeframe[5][x] is between 2:00-2:59 PM
//HourlyTimeframe[6][x] is between 3:00-3:59 PM
//HourlyTimeframe[7][x] is between 4:00-4:59 PM
//HourlyTimeframe[8][x] is between 5:00-5:59 PM
//HourlyTimeframe[9][x] is between 6:00-6:59 PM
//HourlyTimeframe[10][x] is between 7:00-7:59 PM
//HourlyTimeframe[11][x] is between 8:00-8:59 PM
//HourlyTimeframe[12][x] is between 9:00-9:59 PM
//HourlyTimeframe[13][x] is between 10:00-10:59 PM
//HourlyTimeframe[14][x] holds each day's totals

//HourlyTimeframe[x][0] is Sunday
//HourlyTimeframe[x][1] is Monday
//HourlyTimeframe[x][2] is Tuesday
//HourlyTimeframe[x][3] is Wednesday
//HourlyTimeframe[x][4] is Thursday
//HourlyTimeframe[x][5] is Friday
//HourlyTimeframe[x][6] is Monday

namespace HourlySign
{
    class Week
    {
        public int[,] HourlyTimeframe { get; }
        private bool _hasData;
        List<DateTime> _dateRange;
        private string _projectDirectory = Directory.GetParent(
                                Directory.GetCurrentDirectory()).Parent.FullName;

          public Week()
        {
            HourlyTimeframe = new int[15,7];
            _dateRange = new List<DateTime>();
            _hasData = false;
        }

        public void SetWeekRange(DateTime dt)
        {
            DateTime weekFirstDay = dt.AddDays(DayOfWeek.Sunday - dt.DayOfWeek);
            DateTime weekLastDay = weekFirstDay.AddDays(6);
            for (DateTime date = weekFirstDay; date <= weekLastDay; date = date.AddDays(1))
                _dateRange.Add(date);
        }

        public bool FitsInDateRange(DateTime dt)
        {
            DateTime weekFirstDay = _dateRange[0];
            DateTime weekLastDay = _dateRange[6];
            return (dt >= weekFirstDay && dt <= weekLastDay) ? true : false;
        }

        public void PutData(DateTime dt)
        {
            int day = 0;

            foreach (DateTime dtOfWeek in _dateRange)
            {
                if (dt.Date == dtOfWeek.Date)
                {
                    int hour = hourToArrayElement(dt.Hour);
                    HourlyTimeframe[hour, day] += 1;
                    break;
                }
                day++;
            }
        }

        private int hourToArrayElement(int hour)
        {
            return (hour - 9);
        }

        public void TotalEachDay()
        {
            for (int dayOfWeek = 0; dayOfWeek < HourlyTimeframe.GetLength(1); dayOfWeek++)
            {
                for (int hourRange = 0; hourRange < HourlyTimeframe.GetLength(0)-1; hourRange++)
                {
                    HourlyTimeframe[14, dayOfWeek] += HourlyTimeframe[hourRange, dayOfWeek];
                }
            }
        }

        //TODO
        public void Print()
        {
<<<<<<< HEAD
            // Is there a way to get _projectDirectory from Form1?
            string outputFile = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Resources\\weeks.txt";
            using (TextWriter tw = new StreamWriter(outputFile, append: true))
            {
                //print header here of weekdays
                tw.WriteLine("S" + "\t" + "M" + "\t" + "T" + "\t" + "W" + "\t" + "R" + "\t" + "F" + "\t" + "S");
                for (int hourRange = 0; hourRange < HourlyTimeframe.GetLength(0); hourRange++)
                {
                    for (int dayOfWeek = 0; dayOfWeek < HourlyTimeframe.GetLength(1); dayOfWeek++)
                    {
                        tw.Write(HourlyTimeframe[hourRange, dayOfWeek] + "\t");
=======
               // Is there a way to get _projectDirectory from Form1?
               string outputFile = _projectDirectory + "\\Resources\\weeks.txt";
               using (TextWriter tw = new StreamWriter(outputFile, append: true))
               {
                    //print header here of weekdays
                    tw.WriteLine("S" + "\t" + "M" + "\t" + "T" + "\t" + "W" + "\t" + "R" + "\t" + "F" + "\t" + "S");
                    for (int hourRange = 0; hourRange < HourlyTimeframe.GetLength(0); hourRange++)
                    {
                         for (int dayOfWeek = 0; dayOfWeek < HourlyTimeframe.GetLength(1); dayOfWeek++)
                         {
                              tw.Write(HourlyTimeframe[hourRange, dayOfWeek] + "\t");
                         }
                         tw.Write(tw.NewLine);
>>>>>>> 862773f1f5d426135da7e34717842d607d7a6a2f
                    }
                    tw.WriteLine("");
                }
                tw.WriteLine("");
            }
        }
    }
}
