using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEnigma
{
    class Program
    {
        public static Worker Worker { get; set; }
        public static void Main(string[] args)
        {
            Console.WriteLine("\nNetEnigma .NET Obfuscator\n");
            Console.Write("Enter the path to a .NET assembly (DLL or EXE): ");
            string path = Console.ReadLine();
            Worker = new Worker(path);

            Console.WriteLine("\nObfuscation Options\n===========================");
            for (int i = 0; i < Worker.Obfuscations.Count; i++)
            {
                Console.WriteLine(i + 1 + ") " + Worker.Obfuscations[i]);
            }
            Console.Write("\nChoose one or more options above to obfuscate (i.e. \"95178\"): ");
            string opts = Console.ReadLine();

            Console.WriteLine("\nObfuscating...\n");
            Worker.ExecuteObfuscations(opts);
            Worker.Save();
            Console.WriteLine("\nObfuscation Done.\n");
        }
    }
}
