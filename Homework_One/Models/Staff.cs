using System;

namespace Homework_One.Models
{
    class Staff
    {
        // Constructor
        public Staff(Guid idStaff, string fullName, decimal allowance, double salaryRatio, int typeStaff)
        {
            IdStaff = idStaff;
            FullName = fullName;
            Allowance = allowance;
            SalaryRatio = salaryRatio;
            TypeStaff = typeStaff;
        }

        // Properties
        public Guid IdStaff { get; set; }
        public string FullName { get; set; }
        public decimal Allowance { get; set; }
        public double SalaryRatio { get; set; }
        public int TypeStaff { get; set; }
    }
}