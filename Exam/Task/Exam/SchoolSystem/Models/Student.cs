using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolSystem.Enums;
using SchoolSystem.Models.Abstraction;
using SchoolSystem.Models.Contracts;

namespace SchoolSystem.Models
{
    public class Student : Person, IStudent
    {
        private readonly List<Mark> marks;

        public Student(string firstName, string lastName, Grade grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
            this.marks = new List<Mark>();
        }

        public Grade Grade { get; set; }

        public void AddMark(Mark mark)
        {
            this.marks.Add(mark);
        }

        public string ListMarks()
        {
            var builder = new StringBuilder();

            var listedMarks = this.marks
                .Select(m => $"{m.Subject} => {m.Value}")
                .ToList();

            return string.Join(Environment.NewLine, listedMarks);
        }
    }
}
