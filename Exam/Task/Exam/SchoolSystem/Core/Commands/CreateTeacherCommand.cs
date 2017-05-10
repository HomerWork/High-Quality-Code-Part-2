using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Core.Commands
{
    class CreateTeacherCommand
    {
    }
}

namespace SchoolSystem
{
    class CreateTeacherCommand : ICommand
    {



        public string Execute(IList<string> para)
        {
            // TODO: too drunk, implement later
            throw new NotImplementedException();
        }
    }
}
