using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.Core.Commands.Contracts;
using SchoolSystem.Core.Contracts;
using SchoolSystem.Models;

namespace SchoolSystem.Core
{
    public class Engine
    {
        private IReader reader;
        private IWriter writer;

            public Engine(IReader reader, IWriter writer)
            {
                this.reader = reader;
                this.writer = writer;
            }

            public void Start()
            {
                while (true)
                {
                    try
                    {
                        var currentCommand = System.Console.ReadLine();
                        if (currentCommand == "End")
                        {
                            break;
                        }

                        var aadeshName = currentCommand.Split(' ')[0];

                        var assembli = GetType().GetTypeInfo().Assembly;

                        var tpyeinfo = assembli.DefinedTypes
                            .Where(type => type.ImplementedInterfaces.Any(inter => inter == typeof(ICommand)))
                            .FirstOrDefault(type => type.Name.ToLower().Contains(aadeshName.ToLower()));

                        if (tpyeinfo == null)
                        {
                            // throw exception when typeinfo is null
                            throw new ArgumentException("The passed command is not found!");
                        }
                        var aadesh = Activator.CreateInstance(tpyeinfo) as ICommand;
                        var paramss = currentCommand.Split(' ').ToList();
                        paramss.RemoveAt(0);
                        WriteLine(aadesh.Execute(paramss));
                    }
                    catch (Exception ex)
                    {
                        WriteLine(ex.Message);
                    }
                }
            }

            private ConsoleReaderProvider read;

            void WriteLine(string message)
            {

                Console.WriteLine(message);
            }

            internal static Dictionary<int, Teacher> Teachers { get; set; } = new Dictionary<int, Teacher>();

            internal static Dictionary<int, Student> Students { get; set; } = new Dictionary<int, Student>();
    }
}
