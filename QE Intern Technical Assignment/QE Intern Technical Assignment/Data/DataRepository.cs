using System;
using System.Collections.Generic;
using System.Text;
using QE_Intern_Technical_Assignment.Models;

namespace QE_Intern_Technical_Assignment.Data
{
    public class DataRepository : IDataRepository
    {
        public IList<Student> GetStudentsFromDatabase()
        {
            return new List<Student>
            {
                new Student(101, "Mike", Gender.Male, 9),
                new Student(102, "Rose", Gender.Female, 10),
                new Student(103, "James", Gender.Male, 7),
                new Student(104, "William", Gender.Male, 8),
                new Student(105, "Sophia", Gender.Female, 6),
                new Student(106, "Ava", Gender.Female, 8)
            };
        }
    }
}
