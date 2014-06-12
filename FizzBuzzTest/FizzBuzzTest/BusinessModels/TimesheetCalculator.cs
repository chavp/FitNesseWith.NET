using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzTest.BusinessModels
{
    public static class TimesheetCalculator
    {
        public static double Cost(this Timesheet tm, double costPerHour)
        {
            return tm.ElapsedTime.TotalHours * costPerHour;
        }
    }
}
