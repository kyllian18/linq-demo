using System;

namespace linqdemo.Models
{
    public class Cohort
    {
        public int ID { get; set; }
        public string CohortName { get; set; }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int CohortID { get; set; }
    }
}