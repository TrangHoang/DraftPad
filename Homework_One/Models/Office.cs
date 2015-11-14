using System;

namespace Homework_One.Models
{
    class Office : Staff
    {
        // Constructor
        public Office(int idOffice, string department, DateTime workingTime, string position)
            : base(new Guid(), null, 0, 0)
        {
            IdOffice = idOffice;
            Department = department;
            WorkingTime = workingTime;
            Position = position;
        }

        // Properties
        public int IdOffice { get; set; }
        public string Department { get; set; }
        public DateTime WorkingTime { get; set; }
        public string Position { get; set; }
    }
}