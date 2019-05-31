using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Core;

namespace Open.Tests.Core
{
    [TestClass]
    public class IdCodeValidationTests : IdCodeValidation //Kas nii võib teha?
    {
        //IsValid

        //OnlyNumbers
        [TestMethod]
        public static void OnlyNumbersTest()
        {
            //if (string.IsNullOrEmpty(s)) return false;
            //if (string.IsNullOrEmpty(s.Trim())) return false;
            //return s.Trim().All(char.IsDigit);
            string s = "55555555";
            bool acutalResult = OnlyNumbers(s);
            Assert.IsTrue(acutalResult);
        }
        [TestMethod]
        public static void OnlyNumbersNullTest()
        {
            string s = null;
            bool actualResult = OnlyNumbers(s);
            Assert.IsFalse(actualResult);
        }
        [TestMethod]
        public static void OnlyNumbersTrimTest()
        {
            string s = "  55555555    ";
            bool actualResult = OnlyNumbers(s);
            Assert.IsFalse(actualResult);
        }
        [TestMethod]
        public static void OnlyNumbersLettersTest()
        {

        }
        [TestMethod]
        public static void OnlyNumbersSymbolsTest()
        {

        }

        //Error
        [TestMethod]
        public static void ErrorTest() //Test not shown in test explorer
        {
            string s = "Suvaline warning";
            ValidationResult expectedResult = new ValidationResult(s);
            ValidationResult actualResult = Error(s);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
