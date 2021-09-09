using System;
using Autofac;
using QE_Intern_Technical_Assignment.Configuration;
using QE_Intern_Technical_Assignment.Models;
using QE_Intern_Technical_Assignment.Services;

namespace QE_Intern_Technical_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var container = IoCSetup.Configure();
            var sortingService = container.Resolve<ISortingService>();
            var studentsSortedById = sortingService.GetSortedStudents();
            var femaleStudents = sortingService.GetStudentsByGender(Gender.Female);
            var maleStudents = sortingService.GetStudentsByGender(Gender.Male);

            Console.WriteLine("Students sorted by ID");
            for (int i = 0; i < studentsSortedById.Count; i++)
            {
                Console.WriteLine(studentsSortedById[i].Name);
            }

            Console.WriteLine("Female Students");
            for (int i = 0; i < femaleStudents.Count; i++)
            {
                Console.WriteLine(femaleStudents[i].Name);
            }

            Console.WriteLine("Male Students");
            for (int i = 0; i < femaleStudents.Count; i++)
            {
                Console.WriteLine(maleStudents[i].Name);
            }

        }
    }
}
