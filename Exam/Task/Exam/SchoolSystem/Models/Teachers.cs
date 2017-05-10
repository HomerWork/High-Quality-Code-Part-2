using SchoolSystem.Enums;

namespace SchoolSystem.Models
{
    public class Teacher
    {
        public Teacher (string firstName, string lastName, Subject subject)
        {
            this.FName = firstName;
            this.LName = lastName;
            this.Subject = subject;
        }

        public string FName { get; }

        public string LName { get; }

        public Subject Subject { get; set; }

        public void AddMark(Student student, float value)
        {
            var mark = new Mark(this.Subject, value);
            student.AddMark(mark);
        }
    }
}
