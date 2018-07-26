using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using romanNumbers;

namespace UnitTestRomanNumbers
{
    [TestClass]
    public class RomanNumbersTest
    {
        [TestMethod]
        public void roman_i_1returned()
        {
            string rom = "i";
            int res = 1;
            int actual = RomanNum.ConvertToDec(rom);
            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_iii_3returned()
        {
            string rom = "iii";
            int res = 3;
            int actual = RomanNum.ConvertToDec(rom);
            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_iv_4returned()
        {
            string rom = "iv";
            int res = 4;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_v_5returned()
        {
            string rom = "v";
            int res = 5;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_vi_6returned()
        {
            string rom = "vi";
            int res = 6;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_ix_9returned()
        {
            string rom = "ix";
            int res = 9;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_x_10returned()
        {
            string rom = "x";
            int res = 10;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_xi_11returned()
        {
            string rom = "xi";
            int res = 11;
            int actual = RomanNum.ConvertToDec(rom);
            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_xiv_14returned()
        {
            string rom = "xiv";
            int res = 14;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_xxx_30returned()
        {
            string rom = "xxx";
            int res = 30;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_xl_40returned()
        {
            string rom = "xl";
            int res = 40;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_l_50returned()
        {
            string rom = "l";
            int res = 50;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_lxvi_66returned()
        {
            string rom = "lxvi";
            int res = 66;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_xc_90returned()
        {
            string rom = "xc";
            int res = 90;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_c_100returned()
        {
            string rom = "c";
            int res = 100;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_clxvi_166returned()
        {
            string rom = "clxvi";
            int res = 166;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_cd_400returned()
        {
            string rom = "cd";
            int res = 400;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_d_500returned()
        {
            string rom = "d";
            int res = 500;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_dclxvi_666returned()
        {
            string rom = "dclxvi";
            int res = 666;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_cm_900returned()
        {
            string rom = "cm";
            int res = 900;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_m_1000returned()
        {
            string rom = "m";
            int res = 1000;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_mdclxvi_1666returned()
        {
            string rom = "mdclxvi";
            int res = 1666;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_mmmcmxcix_3999returned()
        {
            string rom = "mmmcmxcix";
            int res = 3999;

            int actual = RomanNum.ConvertToDec(rom);

            Assert.AreEqual(res, actual);
        }
        [TestMethod]
        public void roman_xxxx_exeption()
        {
            string rom = "xxxx";
            try
            {
                int actual = RomanNum.ConvertToDec(rom);
            }
            catch (ExeptionRomanNumber ex)
            {
                Assert.AreEqual(ExeptionRes.treeInARow, ex.Message);
            }
        }
        [TestMethod]
        public void roman_q_exeption()
        {
            string rom = "q";
            try
            {
                int actual = RomanNum.ConvertToDec(rom);
            }
            catch (ExeptionRomanNumber ex)
            {
                Assert.AreEqual(string.Format(ExeptionRes.unsupportedChar, rom), ex.Message);
            }
        }
        [TestMethod]
        public void roman_xqii_exeption()
        {
            string rom = "xqii";
            string unsupport = "q";
            try
            {
                int actual = RomanNum.ConvertToDec(rom);
            }
            catch (ExeptionRomanNumber ex)
            {
                Assert.AreEqual(string.Format(ExeptionRes.unsupportedChar, unsupport), ex.Message);
            }
        }
        [TestMethod]
        public void roman_vx_exeption()
        {
            string rom = "vx";
            try
            {
                int actual = RomanNum.ConvertToDec(rom);
            }
            catch (ExeptionRomanNumber ex)
            {
                Assert.AreEqual(ExeptionRes.wrong, ex.Message);
            }
        }
        [TestMethod]
        public void roman_ixiii_exeption()
        {
            string rom = "ixiii";
            int dec = 12;
            string correctRom = "XII";
            try
            {
                int actual = RomanNum.ConvertToDec(rom);
            }
            catch (ExeptionRomanNumber ex)
            {
                Assert.AreEqual(string.Format(ExeptionRes.IncorrectNumber, correctRom, dec, rom), ex.Message);
            }
        }
        [TestMethod]
        public void roman_null_exeption()
        {
            string rom = null;
            try
            {
                int actual = RomanNum.ConvertToDec(rom);
            }
            catch (ExeptionRomanNumber ex)
            {
                Assert.AreEqual(ExeptionRes.nullOrEmpty, ex.Message);
            }
        }
        [TestMethod]
        public void roman_empty_exeption()
        {
            string rom = "";
            try
            {
                int actual = RomanNum.ConvertToDec(rom);
            }
            catch (ExeptionRomanNumber ex)
            {
                Assert.AreEqual(ExeptionRes.nullOrEmpty, ex.Message);
            }
        }
        [TestMethod]
        public void decimal_1_I_returned()
        {
            int value = 1;
            string res = "I";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_100_C_returned()
        {
            int value = 100;
            string res = "C";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_400_CD_returned()
        {
            int value = 400;
            string res = "CD";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_166_CLXVI_returned()
        {
            int value = 166;
            string res = "CLXVI";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_900_CM_returned()
        {
            int value = 900;
            string res = "CM";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_500_D_returned()
        {
            int value = 500;
            string res = "D";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_666_DCLXVI_returned()
        {
            int value = 666;
            string res = "DCLXVI";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_3_III_returned()
        {
            int value = 3;
            string res = "III";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_4_IV_returned()
        {
            int value = 4;
            string res = "IV";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_9_IX_returned()
        {
            int value = 9;
            string res = "IX";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_50_L_returned()
        {
            int value = 50;
            string res = "L";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_66_LXVI_returned()
        {
            int value = 66;
            string res = "LXVI";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_1000_M_returned()
        {
            int value = 1000;
            string res = "M";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_1666_MDCLXVI_returned()
        {
            int value = 1666;
            string res = "MDCLXVI";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_5_V_returned()
        {
            int value = 5;
            string res = "V";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_6_VI_returned()
        {
            int value = 6;
            string res = "VI";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_10_X_returned()
        {
            int value = 10;
            string res = "X";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_90_XC_returned()
        {
            int value = 90;
            string res = "XC";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_11_XI_returned()
        {
            int value = 11;
            string res = "XI";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_14_XIV_returned()
        {
            int value = 14;
            string res = "XIV";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_40_XL_returned()
        {
            int value = 40;
            string res = "XL";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_30_XXX_returned()
        {
            int value = 30;
            string res = "XXX";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_3999_MMMCMXCIX_returned()
        {
            int value = 3999;
            string res = "MMMCMXCIX";
            string actual = RomanNum.ConvertToRoman(value);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void decimal_0_exeption()
        {
            int value = 0;
            try
            {
                string actual = RomanNum.ConvertToRoman(value);
            }
            catch (ExeptionRomanNumber ex)
            {
                Assert.AreEqual(ExeptionRes.wrongRange, ex.Message);
            }
        }
        [TestMethod]
        public void decimal_negotiveNum_exeption()
        {
            int value = -1;
            try
            {
                string actual = RomanNum.ConvertToRoman(value);
            }
            catch (ExeptionRomanNumber ex)
            {
                Assert.AreEqual(ExeptionRes.wrongRange, ex.Message);
            }
        }
        [TestMethod]
        public void decimal_4000_exeption()
        {
            int value = 4000;
            try
            {
                string actual = RomanNum.ConvertToRoman(value);
            }
            catch (ExeptionRomanNumber ex)
            {
                Assert.AreEqual(ExeptionRes.wrongRange, ex.Message);
            }
        }
        [TestMethod]
        public void numb_notEqual()
        {
            var t1 = RomanNum.ConvertToRoman(1);
            string t2 = RomanNum.Numb;            
            var t3 = RomanNum.ConvertToRoman(10);
            string t4 = RomanNum.Numb;
            Assert.AreNotEqual(t2, t4);
        }
    }
}
