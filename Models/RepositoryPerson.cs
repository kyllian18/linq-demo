using System;
using System.Collections.Generic;

namespace linqdemo.Models
{
    public class RepositoryPerson
    {
        public static List<Person> Persons()
        {
            List<Person> people = new List<Person>()
            {
                new Person() { ID = 1, Name = "Person 1", Address = "Ireland", Salary = 10000 },
                new Person() { ID = 2, Name = "Person 2", Address = "Ireland", Salary = 20000 },
                new Person() { ID = 3, Name = "Person 3", Address = "Country 3", Salary = 30000 },
                new Person() { ID = 4, Name = "Person 4", Address = "Country 4", Salary = 40000 },
                new Person() { ID = 5, Name = "Person 5", Address = "Country 5", Salary = 50000 },
                new Person() { ID = 6, Name = "Person 6", Address = "Country 6", Salary = 60000 },
                new Person() { ID = 7, Name = "Person 7", Address = "Country 7", Salary = 70000 },
                new Person() { ID = 8, Name = "Person 8", Address = "Country 8", Salary = 80000 },
                new Person() { ID = 9, Name = "Person 9", Address = "Country 9", Salary = 90000 }
            };
            return people;
        }
    }
}