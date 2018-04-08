using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourlySign
{
    class EnableRun
    {
        public bool FileSelected { get; set; }
        public bool OutFileLocation { get; set; }

        public EnableRun()
        {
            FileSelected = false;
            OutFileLocation = false;
        }

        public bool BothSelected()
        {
            return (FileSelected && OutFileLocation) ? true : false;
        }
    }
}
