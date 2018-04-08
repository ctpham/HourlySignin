using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourlySign
{
    class DayAndTotal
    {
        public DateTime YearAndMonth { get; } 
        public int Total { get; }

        public DayAndTotal(DateTime yearAndMonth, int total)
        {
            this.YearAndMonth = yearAndMonth;
            this.Total = total;
        }
    }
}
