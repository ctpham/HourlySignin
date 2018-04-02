using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourlySign
{
    class CACE
    {
        private string DateTime { get; }
        private string FirstName { get; }
        private string LastName { get; }
        private string Reason { get; }
        private string Subject { get; }

        public CACE(string dateTime, string firstName,
                string lastName, string reason, string subject)
        {
            DateTime = dateTime;
            FirstName = firstName;
            LastName = lastName;
            Reason = reason;
            Subject = subject;
        }
    }
}
