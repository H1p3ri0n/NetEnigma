using NetEnigma.Runtime;
using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NetEnigma.Mutations.MutationObf;

namespace NetEnigma
{
    public class Utils
    {
        public static void Shuffle<T>(IList<T> list)
        {
            for (int i = list.Count - 1; i > 1; i--)
            {
                int k = RuntimeHelper.Random.Next(i + 1);
                T tmp = list[k];
                list[k] = list[i];
                list[i] = tmp;
            }
        }

        public static bool CheckArithmetic(Instruction instruction)
        {
            if (!instruction.IsLdcI4())
                return false;
            if (instruction.GetLdcI4Value() <= 1)
                return false;
            return true;
        }

        public static string ScrambleString(string str)
        {
            char[] chars = new char[str.Length];
            Random rand = new Random();
            int index = 0;
            while (str.Length > 0)
            {
                // Get a random number between 0 and the length of the word. 
                int next = rand.Next(0, str.Length - 1);
                // Take the character from the random position and add to our char array.
                chars[index] = str[next];
                // Remove the character from the word.
                str = str.Substring(0, next) + str.Substring(next + 1);
                ++index;
            }
            return new String(chars);
        }
    }
}
