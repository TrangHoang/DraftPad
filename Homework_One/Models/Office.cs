using System;

namespace Homework_One.Models
{
    class Office : Staff
    {
        // Constructor
        public Office(Guid idStaff, string fullName, decimal allowance, double salaryRatio, int typeStaff,
            string department, DateTime workingTime, string position)
            : base(new Guid(), null, 0, 0, 0)
        {
            IdStaff = idStaff;
            FullName = fullName;
            Allowance = allowance;
            SalaryRatio = salaryRatio;
            TypeStaff = typeStaff;
            Department = department;
            WorkingTime = workingTime;
            Position = position;
        }

        // Properties
        public string Department { get; set; }
        public DateTime WorkingTime { get; set; }
        public string Position { get; set; }
    }
}