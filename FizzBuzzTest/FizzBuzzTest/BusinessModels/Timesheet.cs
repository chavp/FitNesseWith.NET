using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzTest.BusinessModels
{
    public class Timesheet
    {
        public Timesheet(DateTime startDate)
        {
            StartDate = startDate;
        }

        public TimeSpan ElapsedTime { get; set; }
        public DateTime StartDate { get; protected set; }
    }
}
