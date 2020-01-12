using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        private decimal weekSalary;

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if (value<=10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                weekSalary = value;
            }
        }

        private decimal workHours;

        public decimal WorkHours
        {
            get { return workHours; }
            set
            {
                if (value<1 || value>12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                workHours = value;
            }
        }

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHours) : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHours = workHours;
        }
    }
}
