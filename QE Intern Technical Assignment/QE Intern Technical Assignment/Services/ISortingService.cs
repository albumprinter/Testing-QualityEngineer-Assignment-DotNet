using System;
using System.Collections.Generic;
using System.Text;
using QE_Intern_Technical_Assignment.Models;

namespace QE_Intern_Technical_Assignment.Services
{
    public interface ISortingService
    {
        IList<Student> GetStudentsByGender(Gender gender);

        IList<Student> GetSortedStudents();
    }
}
