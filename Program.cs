using System;
using System.Security.Principal;
using System.Diagnostics;
using System.IO;
using System.Linq;


namespace SOLID_Dependency_Inversion_Principle_quête_3
{
    public class Program
    {
        public static void Main()
        {
            Terminal terminal = new Terminal();
            while (!terminal.Exited)
            {
                Command command = terminal.PromptCommand();
                terminal.ExecuteCommand(command);
            }
        }
    }
}