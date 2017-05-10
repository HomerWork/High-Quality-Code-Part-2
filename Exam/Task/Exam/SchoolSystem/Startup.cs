using SchoolSystem.Models;
using System.Reflection;
using System.Threading;
using SchoolSystem;
using System;

using SchoolSystem;
using System;
using System.Collections.Generic;
using System.Reflection;using System.Threading;

using System.Linq;
using SchoolSystem;
using System.Collections.Generic;
using System.Linq;

namespace SchoolSystem
{
    
    public class Startup
    {
        static void Main()
        {
            // TODO: abstract at leest 2 mor provider like thiso ne
            var padhana = new ConsoleReaderProvider();

            var service = new Engine();
            service.Execute(padhana);
        }
    }
    class ConsoleReaderProvider
    {
        // TODO: make ConsoleReaderProvider implement IReader
        public string PadhanaLine()
        {
            return Console.ReadLine();
        }
    }
}