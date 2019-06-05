using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Core;

namespace Open.Tests.Core
{
    [TestClass]
    public class IdCodeValidationTeslts : IdCodeValidation //Kas nii võib teha?
    {
        //IsValid
        //protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        //{
        //    if (value == null) return Error(requiredField);
        //    var s = value.ToString();
        //    if (s.Trim().Length != 11) return Error(wrongLength);
        //    if (!OnlyNumbers(s)) return Error(useOnlyNumbers);
        //    return ValidationResult.Success;
        //}

        [TestMethod]
        public static void IsValidCorrectTest()
        {
            object value = "5";
            string s = value.ToString();
            //if (string.IsNullOrEmpty(s)) return false;
            //if (string.IsNullOrEmpty(s.Trim())) return false;
            //return s.Trim().All(char.IsDigit);
            
            var actualResult = IdCodeValidation.IsValid(value, ValidationContext context);
            Assert.AreEqual(ValidationResult.Success, actualResult);
        }

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
        public static void OnlyNumbersNullorEmptyTest()
        {
            string s = null;
            bool actualResult = OnlyNumbers(s);
            Assert.IsFalse(actualResult);
        }
        [TestMethod]
        public static void OnlyNumbersNullorEmptryTrimTest()
        {
            string s = "      ";
            bool actualResult = OnlyNumbers(s);
            Assert.IsFalse(actualResult);
        }
        [TestMethod]
        public static void OnlyNumbersLettersTest()
        {
            string s = "ABC";
            bool actualResult = OnlyNumbers(s);
            Assert.IsFalse(actualResult);
        }
        [TestMethod]
        public static void OnlyNumbersSymbolsTest()
        {
            string s = "@$";
            bool actualResult = OnlyNumbers(s);
            Assert.IsFalse(actualResult);
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
