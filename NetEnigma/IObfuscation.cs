using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEnigma
{
    public interface IObfuscation
    {
        void Execute(ModuleDefMD md);
    }
}
