using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace romanNumbers
{
    public class RomanNum
    {
        public RomanNum(int a) { roman = ConvertToRoman(a); dec = a; }
        private int dec;
        public int Dec
        {
            get { return dec; }
            set {               
                dec = value;
                roman = ConvertToRoman(dec);
            }
        }
        private string roman;
        public string Roman
        {
            get { return roman; }
            private set { roman = value; }
        }
        public static int ConvertToDec(string value)
        {
            if ((value == null) || (value.Length == 0))
                throw new ExeptionRomanNumber(ExeptionRes.nullOrEmpty);
            int res = 0;
            int t = 0;
            int max = 0;
            int[] tprev = new int[3];
            for (int i2 = tprev.Length - 1; i2 >= 0; i2--)
            {
                tprev[i2] = 0;
            }
            for (int i = value.Length - 1; i >= 0; i--)
            {
                t = getRoman(value[i]);
                if (t >= tprev[0])
                    res += t;
                else
                    res -= t;
                tprev = getPrev(tprev, t, max);
                if (t > max)
                    max = t;
            }
            if (value.ToUpper() != ConvertToRoman(res))
                throw new ExeptionRomanNumber(string.Format(ExeptionRes.IncorrectNumber, ConvertToRoman(res), res, value));
            return res;
        }
        public static string ConvertToRoman(int decNum)
        {
            string romNum = "";
            if ((decNum < 1) || (decNum > 3999))
                throw new ExeptionRomanNumber(ExeptionRes.wrongRange);
            var romanMap = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(1, "I"),
                new KeyValuePair<int, string>(4, "IV"),
                new KeyValuePair<int, string>(5, "V"),
                new KeyValuePair<int, string>(9, "IX"),
                new KeyValuePair<int, string>(10, "X"),
                new KeyValuePair<int, string>(40, "XL"),
                new KeyValuePair<int, string>(50, "L"),
                new KeyValuePair<int, string>(90, "XC"),
                new KeyValuePair<int, string>(100, "C"),
                new KeyValuePair<int, string>(400, "CD"),
                new KeyValuePair<int, string>(500, "D"),
                new KeyValuePair<int, string>(900, "CM"),
                new KeyValuePair<int, string>(1000, "M"),
            };
            for (int i = romanMap.Count - 1; i >= 0; i--)
            {
                while (decNum >= romanMap[i].Key)
                {
                    romNum += romanMap[i].Value;
                    decNum -= romanMap[i].Key;
                }
            }

            return romNum;
        }
        private static int[] getPrev(int[] prev, int t, int max)
        {
            if ((prev.Length >= 3) && ((prev[0] == prev[1]) && (prev[1] == prev[2]) && (prev[2] == t)))
            {
                throw new ExeptionRomanNumber(ExeptionRes.treeInARow);
            }
            if ((t < max) && ((prev[0] != max) || (t == 5) || (t == 50) || (t == 500)))
            {
                throw new ExeptionRomanNumber(ExeptionRes.wrong);
            }
            for (int i2 = prev.Length - 1; i2 > 0; i2--)
            {
                prev[i2] = prev[i2 - 1];
            }
            prev[0] = t;
            return prev;
        }
        private static int getRoman(char ch)
        {
            switch (ch)
            {
                case 'I':
                case 'i':
                    return 1;
                    break;
                case 'V':
                case 'v':
                    return 5;
                    break;
                case 'X':
                case 'x':
                    return 10;
                    break;
                case 'L':
                case 'l':
                    return 50;
                    break;
                case 'C':
                case 'c':
                    return 100;
                    break;
                case 'D':
                case 'd':
                    return 500;
                    break;
                case 'M':
                case 'm':
                    return 1000;
                    break;
                default:
                    throw new ExeptionRomanNumber(String.Format(ExeptionRes.unsupportedChar, ch));
            }
        }
    }
}
