using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.SharedLib.Shared.Extensions
{

    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredByConditionAttribute : ValidationAttribute
    {
        private readonly string propertyName;
        private readonly bool condition;

        public RequiredByConditionAttribute(string propertyName, bool condition)
        {
            this.propertyName = propertyName;
            this.condition = condition;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var propertyInfo = validationContext.ObjectType.GetProperty(propertyName);
            if (propertyInfo is null) return ValidationResult.Success;

            var val = propertyInfo.GetValue(validationContext.ObjectInstance);
            if (val is bool b && b == condition)
            {
                return value is { } ? ValidationResult.Success : new ValidationResult(ErrorMessage ?? $"{propertyName} is {condition}");
            }

            return ValidationResult.Success;
        }
    }
}
