using System;

namespace Homework_One.Models
{
    class Professor : Staff
    {
        // Constructor
        public Professor(Guid idStaff, string fullName, decimal allowance, double salaryRatio, int typeStaff,
            string faculty, float monthlyTeachingTime, string academicDegree)
            : base(new Guid(), null, 0, 0,0)
        {
            IdStaff = idStaff;
            FullName = fullName;
            Allowance = allowance;
            SalaryRatio = salaryRatio;
            TypeStaff = typeStaff;
            Faculty = faculty;
            MonthlyTeachingTime = monthlyTeachingTime;
            AcademicDegree = academicDegree;
        }

        // Properties
        public string Faculty { get; set; }
        public float MonthlyTeachingTime { get; set; }
        public string AcademicDegree { get; set; }
    }
}