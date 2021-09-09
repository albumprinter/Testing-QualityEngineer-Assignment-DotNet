using System;
using System.Collections.Generic;
using System.Text;
using QE_Intern_Technical_Assignment.Models;

namespace QE_Intern_Technical_Assignment.Data
{
    public interface IDataRepository
    {
        IList<Student> GetStudentsFromDatabase();

    }
}
