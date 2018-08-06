using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using romanNumbers;

namespace UnitTestRomanNumbers
{
    [TestClass]
    public class RomanNumbersTest
    {
        [DataRow(1, "I")]
        [DataRow(3, "III")]
        [DataRow(4, "IV")]
        [DataRow(5, "V")]
        [DataRow(6, "VI")]
        [DataRow(9, "IX")]
        [DataRow(10, "X")]
        [DataRow(11, "XI")]
        [DataRow(14, "XIV")]
        [DataRow(40, "XL")]
        [DataRow(50, "L")]
        [DataRow(66, "LXVI")]
        [DataRow(90, "XC")]
        [DataRow(100, "C")]
        [DataRow(166, "CLXVI")]
        [DataRow(400, "CD")]
        [DataRow(500, "D")]
        [DataRow(666, "DCLXVI")]
        [DataRow(900, "CM")]
        [DataRow(1000, "M")]
        [DataRow(1666, "MDCLXVI")]
        [DataRow(3999, "MMMCMXCIX")]
        [TestMethod]
        public void roman_to_int(int integerVersion, string romanVersion)
        {
            int actual = RomanNum.ConvertToDec(romanVersion);
            Assert.AreEqual(integerVersion, actual);
        }
        [DataRow(1, "I")]
        [DataRow(3, "III")]
        [DataRow(4, "IV")]
        [DataRow(5, "V")]
        [DataRow(6, "VI")]
        [DataRow(9, "IX")]
        [DataRow(10, "X")]
        [DataRow(11, "XI")]
        [DataRow(14, "XIV")]
        [DataRow(40, "XL")]
        [DataRow(50, "L")]
        [DataRow(66, "LXVI")]
        [DataRow(90, "XC")]
        [DataRow(100, "C")]
        [DataRow(166, "CLXVI")]
        [DataRow(400, "CD")]
        [DataRow(500, "D")]
        [DataRow(666, "DCLXVI")]
        [DataRow(900, "CM")]
        [DataRow(1000, "M")]
        [DataRow(1666, "MDCLXVI")]
        [DataRow(3999, "MMMCMXCIX")]
        [TestMethod]
        public void int_to_roman(int integerVersion, string romanVersion)
        {
            string actual = RomanNum.ConvertToRoman(integerVersion);
            Assert.AreEqual(romanVersion, actual);
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
            RomanNum a1 = new RomanNum(1);
            string s1 = a1.Roman;
            a1.Dec = 2;
            string s2 = a1.Roman;
            Assert.AreNotEqual(s1, s2);
        }
    }
}
