using System;
using System.Collections.Generic;
using System.Linq;
using linqdemo.Models;

namespace linqdemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ShowStudents();
        }

        public static void ShowPeople()
        {
            List<Person> people = RepositoryPerson.Persons();

            //foreach (Person person in people)
            //{
            //    Console.WriteLine($"Person is {person.ID}");
            //}

            // Existing ID
            Person p1 = people.Where(x => x.ID == 1).First();

            Console.WriteLine($"Person is {p1.Name}");
            Console.WriteLine();

            // Non-existing ID
            Person p31 = people.Where(x => x.ID == 31).FirstOrDefault();

            if (p31 == null)
            {
                Console.WriteLine("Person is not found");
            }
            else
            {
                Console.WriteLine($"Person is {p1.Name}");
            }
            Console.WriteLine();

            // List
            List<Person> listBelow50k = people.Where(x => x.Salary <= 50000).ToList();

            foreach (Person person in listBelow50k)
            {
                Console.WriteLine($"Person ID is {person.ID} and earns {person.Salary}");
            }
            Console.WriteLine();

            // Count
            int countIreland = people.Where(x => x.Address == "Ireland").Count();

            Console.WriteLine($"{countIreland} people live in Ireland");

            IEnumerable<string> result = from x in people where x.Name.Length > 4 select x.Name;

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }

        public static void ShowStudents()
        {
            // Students in class 2
            var result = from student in RepositoryCollege.Students()
                         join cohort in RepositoryCollege.Cohorts() on student.CohortID equals cohort.ID
                         where student.CohortID == 2
                         select new
                         {
                             _Student = student.StudentName,
                             _Cohort = cohort.CohortName
                         };

            foreach (var item in result)
            {
                Console.WriteLine($"{item._Student}\t{item._Cohort}");
            }
        }
    }
}