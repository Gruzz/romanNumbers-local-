using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace romanNumbers
{
    public class RomanNum
    {
        private static string numb;
        public static string Numb
        {
            get { return numb; }
            private set { Numb = numb; }
        }
        public static int ConvertToDec(string value)
        {
            if ((value == null) || (value.Length == 0))
                throw new ExeptionRomanNumber( ExeptionRes.nullOrEmpty);
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
                throw new ExeptionRomanNumber( string.Format(ExeptionRes.IncorrectNumber, ConvertToRoman(res), res, value));
            return res;
        }
        public static string ConvertToRoman(int decNum)
        {
            string romNum = "";
            if ((decNum < 1) || (decNum > 3999))
                throw new ExeptionRomanNumber( ExeptionRes.wrongRange);
            while (decNum >= 1000)
            {
                romNum += "M";
                decNum -= 1000;
            }
            while (decNum >= 900)
            {
                romNum += "CM";
                decNum -= 900;
            }
            while (decNum >= 500)
            {
                romNum += "D";
                decNum -= 500;
            }
            while (decNum >= 400)
            {
                romNum += "CD";
                decNum -= 400;
            }
            while (decNum >= 100)
            {
                romNum += "C";
                decNum -= 100;
            }
            while (decNum >= 90)
            {
                romNum += "XC";
                decNum -= 90;
            }
            while (decNum >= 50)
            {
                romNum += "L";
                decNum -= 50;
            }
            while (decNum >= 40)
            {
                romNum += "XL";
                decNum -= 40;
            }
            while (decNum >= 10)
            {
                romNum += "X";
                decNum -= 10;
            }
            while (decNum >= 9)
            {
                romNum += "IX";
                decNum -= 9;
            }
            while (decNum >= 5)
            {
                romNum += "V";
                decNum -= 5;
            }
            while (decNum >= 4)
            {
                romNum += "IV";
                decNum -= 4;
            }
            while (decNum >= 1)
            {
                romNum += "I";
                decNum -= 1;
            }
            numb = romNum;
            return romNum;
        }
        private static int[] getPrev(int[] prev, int t, int max)
        {
            if ((prev.Length >= 3) && ((prev[0] == prev[1]) && (prev[1] == prev[2]) && (prev[2] == t)))
            {
                throw new ExeptionRomanNumber( ExeptionRes.treeInARow);
            }
            if ((t < max) && ((prev[0] != max) || (t == 5) || (t == 50) || (t == 500)))
            {
                throw new ExeptionRomanNumber( ExeptionRes.wrong);
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
                    throw new ExeptionRomanNumber( String.Format(ExeptionRes.unsupportedChar, ch));
            }
        }
    }
}
