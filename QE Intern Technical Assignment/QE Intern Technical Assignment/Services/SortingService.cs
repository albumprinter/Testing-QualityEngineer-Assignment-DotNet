using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QE_Intern_Technical_Assignment.Data;
using QE_Intern_Technical_Assignment.Models;

namespace QE_Intern_Technical_Assignment.Services
{
    public class SortingService : ISortingService
    {
        private readonly IDataRepository _dataRepository;

        public SortingService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public IList<Student> GetStudentsByGender(Gender gender)
        {
            return GetStudentsByGender(_dataRepository.GetStudentsFromDatabase(), gender);
        }

        public IList<Student> GetStudentsByGender(IList<Student> students, Gender gender)
        {
            // Filter out students with Gender == gender
            // Return filtered list of students

            throw new NotImplementedException();
        }

        public IList<Student> GetSortedStudents()
        {
            var studentsFromDatabase = _dataRepository.GetStudentsFromDatabase();

            // Sort Students By Id
            // Return Sorted List

            throw new NotImplementedException();
        }


    }
}
