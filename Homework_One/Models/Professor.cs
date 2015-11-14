using System;

namespace Homework_One.Models
{
    class Professor : Staff
    {
        // Constructor
        public Professor(int idProfessor, string faculty, float monthlyTeachingTime, string academicDegree)
            : base(new Guid(), null, 0, 0)
        {
            IdProfessor = idProfessor;
            Faculty = faculty;
            MonthlyTeachingTime = monthlyTeachingTime;
            AcademicDegree = academicDegree;
        }

        // Properties
        public int IdProfessor { get; set; }
        public string Faculty { get; set; }
        public float MonthlyTeachingTime { get; set; }
        public string AcademicDegree { get; set; }
    }
}