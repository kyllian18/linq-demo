using System;
using System.Collections.Generic;

namespace linqdemo.Models
{
    public class RepositoryCollege
    {
        public static List<Cohort> Cohorts()
        {
            List<Cohort> cohorts = new List<Cohort>()
            {
                new Cohort() { ID = 1, CohortName = "English" },
                new Cohort() { ID = 2, CohortName = "French" },
                new Cohort() { ID = 3, CohortName = "Italian" },
                new Cohort() { ID = 4, CohortName = "Spanish" },
            };
            return cohorts;
        }

        public static List<Student> Students()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { CohortID = 1, StudentID = 1, StudentName = "Bruce Wayne" },
                new Student() { CohortID = 2, StudentID = 2, StudentName = "Peter Parker" },
                new Student() { CohortID = 2, StudentID = 3, StudentName = "David Banner" },
                new Student() { CohortID = 3, StudentID = 4, StudentName = "Clark Kent" }
            };
            return students;
        }
    }
}