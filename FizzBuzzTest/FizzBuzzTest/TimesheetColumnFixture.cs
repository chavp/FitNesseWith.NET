using fit;
using FizzBuzzTest.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzTest
{
    public class TimesheetColumnFixture : ColumnFixture
    {

        public DateTime StartDate { get; set; }
        public uint ElapsedTimeHours { get; set; }
        public double CostPerHour { get; set; }

        public double Cost()
        {
            Timesheet timesheetUT = new Timesheet(StartDate)
            {
                ElapsedTime = TimeSpan.FromHours(ElapsedTimeHours)
            };

            return timesheetUT.Cost(CostPerHour);
        }
    }
}
