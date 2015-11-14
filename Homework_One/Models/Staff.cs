using System;

namespace Homework_One.Models
{
    class Staff
    {
        // Constructor
        public Staff(Guid idStaff, string fullName, decimal allowance, double salaryRatio)
        {
            IdStaff = idStaff;
            FullName = fullName;
            Allowance = allowance;
            SalaryRatio = salaryRatio;
        }

        // Properties
        public Guid IdStaff { get; set; }
        public string FullName { get; set; }
        public decimal Allowance { get; set; }
        public double SalaryRatio { get; set; } 
    }
}