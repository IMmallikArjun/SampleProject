
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RomanNumerals
{
    public class RomanNumeralTranslater
    {
        /*
         Symbol	Value
        I		1
        V		5
        X		10
        L		50
        C		100
        D		500
        M		1,000
        */                

        public static int Translate(string romanNumeral)
        {
            int result = 0;
            romanNumeral = romanNumeral.ToUpper();
            foreach (var letter in romanNumeral)
            {
                int romVal = RomanValuesInDecimal(letter);
                if (romVal == 0)
                {
                    result = 0;
                    break;
                }
                result += romVal;
            }

            if (result != 0)
            {

                if (Regex.IsMatch(romanNumeral, "(?i)(iv|ix)"))                    
                {
                    result = result - 2;
                }

                if (Regex.IsMatch(romanNumeral, "(?i)(xl|xc)"))
                {
                    result = result - 20;
                }

                if (Regex.IsMatch(romanNumeral, "(?i)(cd|cm)"))
                {
                    result = result - 200;
                }
            }

            return result;
        }

        public static int RomanValuesInDecimal(char Roman)
        {
            switch (Roman)
            {
                case 'M':
                    {
                        return 1000;
                    }
                case 'D':
                    {
                        return 500;
                    }
                case 'C':
                    {
                        return 100;
                    }
                case 'L':
                    {
                        return 50;
                    }
                case 'X':
                    {
                        return 10;
                    }
                case 'V':
                    {
                        return 5;
                    }
                case 'I':
                    {
                        return 1;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }

    }
}
