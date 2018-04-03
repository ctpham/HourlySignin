using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourlySign
{
    class CACE
    {
        private DateTime DateTime { get; }
        private string FirstName { get; }
        private string LastName { get; }
        private string Reason { get; }
        private string Subject { get; }

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

            int month, day, year, hour, minute;
            month = Int32.Parse(split[0]);
            day = Int32.Parse(split[1]);
            year = Int32.Parse(split[2]);
            hour = Int32.Parse(split[3]);
            minute = Int32.Parse(split[4]);

            return new DateTime(year, month, day, hour, minute, 0);
        }
    }
}
