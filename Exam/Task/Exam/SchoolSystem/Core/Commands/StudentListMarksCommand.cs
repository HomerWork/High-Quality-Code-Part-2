using System.Collections.Generic;

namespace SchoolSystem
{
    class StudentListMarksCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {            
            return Engine.students[int.Parse(parameters[0])].ListMarks();
        }
    }
}