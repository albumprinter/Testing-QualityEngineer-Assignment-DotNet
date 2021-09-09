using System;
using System.Collections.Generic;
using System.Text;

namespace QE_Intern_Technical_Assignment.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Score { get; set; }

        public Gender Gender { get; set; }

        public Student(int id, string name, Gender gender, double score)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Score = score;
        }
    }
}
