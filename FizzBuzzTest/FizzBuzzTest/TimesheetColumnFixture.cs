using fit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzTest
{
    public class TimesheetColumnFixture : ColumnFixture
    {
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public double Rate { get; set; }

        public double Pay()
        {
            return (Rate * HoursWorked());
        }

        // returns the number of hours worked
        public double HoursWorked()
        {
            TimeSpan t = CheckOutTime.Subtract(CheckInTime);
            double s = ((double)t.Hours) + ((double)t.Minutes / 100);
            return s;
        }

    }
}
