using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Principal;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace SOLID_Dependency_Inversion_Principle_quête_3
{
    public abstract class CommandImporter
    {
        public string _promptString;
        public bool Exited { get; set; }


        public abstract Command PromptCommand();

        public abstract string Prompt();

        public abstract void ExecuteCommand(Command command);
       
    }

}
