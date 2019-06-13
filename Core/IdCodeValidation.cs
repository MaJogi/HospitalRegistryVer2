using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Open.Core
{
    public class IdCodeValidation : ValidationAttribute
    {
        protected const string requiredField = "Required field!";
        protected const string wrongLength = "Wrong length! ID Code lenght is 11 numbers";
        protected const string useOnlyNumbers = "Use only numbers";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return Error(requiredField);
            var s = value.ToString();
            if (s.Trim().Length != 11) return Error(wrongLength);
            if (!OnlyNumbers(s)) return Error(useOnlyNumbers);
            return ValidationResult.Success;
        }

        internal static bool OnlyNumbers(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            if (string.IsNullOrEmpty(s.Trim())) return false;
            return s.Trim().All(char.IsDigit);
        }
        internal static ValidationResult Error(string s)
        {
            return new ValidationResult(s);
        }
    }
}