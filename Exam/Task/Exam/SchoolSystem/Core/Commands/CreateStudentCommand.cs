using System.Collections.Generic;
using SchoolSystem.Enums;
using SchoolSystem.Models;

namespace SchoolSystem.Core.Commands
{
    public class CreateStudentCommand
    {
        private static int currentStudentId = 0;

        public string Execute(IList<string> parameters)
        {
            var firstName = parameters[0];
            var lastName = parameters[1];
            var grade = (Grade)int.Parse(parameters[2]);

            var createdStudent = new Student(firstName, lastName, grade);
            Engine.Students.Add(currentStudentId, createdStudent);

            return $"A new student with name {firstName} {lastName}, grade {grade} and ID {currentStudentId++} was created.";
        }
    }
}
