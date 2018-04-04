using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourlySign
{
    class CACE : IComparable<CACE>
    {
        public DateTime DateTime { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Reason { get; }
        public string Subject { get; }

        public CACE(string dateTime, string firstName,
                string lastName, string reason, string subject)
        {
            DateTime = parseDateTime(dateTime);
            FirstName = firstName;
            LastName = lastName;
            Reason = reason;
            Subject = subject; 
        }
        
        private DateTime parseDateTime(string dateTime)
        {
            string[] split = dateTime.Split(new Char[] {'/', ':', ' '});

            int month, day, year, hour, minute, second;
            string period; //AM or PM
            month = Int32.Parse(split[0]);
            day = Int32.Parse(split[1]);
            year = Int32.Parse(split[2]);
            hour = Int32.Parse(split[3]);
            minute = Int32.Parse(split[4]);
            second = Int32.Parse(split[5]);
            period = split[6];

            hour = convertToMilitaryTime(hour, period);

            return new DateTime(year, month, day, hour, minute, second);
        }

        private int convertToMilitaryTime(int hour, string period)
        {
            if (period.Equals("PM") && hour != 12)
                hour += 12;
            if (period.Equals("AM") && hour == 12)
                hour += 12;
            return hour;
        }
        
        public string ToString()
        {
            return DateTime.ToString() + " " + FirstName + " " +
                   LastName + " " + Reason + " " + Subject;
        }

        public int CompareTo(CACE other)
        {
            return this.DateTime.CompareTo(other.DateTime);
        }
    }
}
