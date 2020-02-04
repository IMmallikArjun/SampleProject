using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class DictionaryExample
    {
        private Dictionary<char, int> romanNumerals;

        private DictionaryExample()
        {
            romanNumerals.Add('M', 1000);
            romanNumerals.Add('X',10);
            romanNumerals.Add('L', 50);
            romanNumerals.Add('C', 100);
            romanNumerals.Add('D', 500);
            romanNumerals.Add('V', 5);
            romanNumerals.Add('I', 1);

            foreach (KeyValuePair<char, int> romanNumeral in romanNumerals)
            {
                Console.WriteLine("{1} = {2}", romanNumeral.Key, romanNumeral.Value);
            }
        }
    }
}
