using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnlib.DotNet;

namespace NetEnigma
{
    public class RenameObfuscation : IObfuscation
    {
        public void Execute(ModuleDefMD md)
        {
            foreach (var type in md.Types)
            {
                // Renaming some of the special named methods will cause crash.
                foreach (var method in type.Methods.Where(x => !x.IsConstructor && !x.IsVirtual && !x.IsSpecialName))
                    Renamer.Rename(method, Renamer.RenameMode.Logical, 3);
            }
        }
    }
}
