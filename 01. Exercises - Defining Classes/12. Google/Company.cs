using System;
using System.Collections.Generic;

namespace Google
{
    public class Company
    {
        public string CompanyName { get; set; }

        public string Department { get; set; }

        public decimal Salary { get; set; }

        public Company(string companyName, string department, decimal salary)
        {
            this.CompanyName = companyName;
            this.Department = department;
            this.Salary = salary;
        }

        public override string ToString()
        {
             return $"{CompanyName} {Department} {Salary:F2}";
        }
    }
}
