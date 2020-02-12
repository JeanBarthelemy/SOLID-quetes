using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Principal;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace SOLID_Dependency_Inversion_Principle_quête_3
{
    public class Terminal : CommandImporter
    {
        private string _promptString;
        public Terminal()
        {
            _promptString = String.Format("{0}$ ", System.Security.Principal.WindowsIdentity.GetCurrent().Name);
            Exited = false;
        }

        public override Command PromptCommand()
        {
            string commandLine = Prompt();
            return new Command(commandLine);
        }


        public override string Prompt()
        {
            
            Console.Write(_promptString);
            string userCommand = Console.ReadLine();
            return userCommand;
           
        }

        public override void ExecuteCommand(Command command)
        {
            try
            {
                command.Launch();
                if (command.Output.Length > 0)
                {
                    Console.WriteLine(command.Output);
                }
            }
            catch (InvalidOperationException exception)
            {
                Console.Error.WriteLine("{0}: path not found", command);
            }
        }



    }
}
