using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourlySign
{
    class Week
    {
        public int[] HourlyTimeframe { get; }
        private bool _hasData;
        List<DateTime> _dateRange;

        public Week()
        {
            HourlyTimeframe = new int[10];
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
    }
}
