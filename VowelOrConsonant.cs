using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicCorePrograms
{
    public class VowelOrConsonant
    {
        public static void CheckVowelOrConsonant()
        {
            char ch;
            Console.WriteLine("enter any character to check vowel or consonant");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine(ch + "is Vowel");

            }
            else
            {
                Console.WriteLine(ch + "is consonant");
            }
        }
    }
}
