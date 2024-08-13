using System.ComponentModel.DataAnnotations;

namespace MVC_Assignment2.Models
{
    public class Validator:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                int year = Convert.ToDateTime(value).Year;
                if (year >= 2002 && year <= 2005)
                {
                    return ValidationResult.Success;
                }
            }
                return new ValidationResult(ErrorMessage ?? "dob year should be between 2002 to 2005 ");
            
        }



    }


    public class DateOfJoiningValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
               DateTime? dateTime=(DateTime?)value;
                if ((dateTime <=DateTime.Now))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(ErrorMessage ?? "doj year should be less than current date ");

        }
    }


    public class DeptValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string? dept = (string)value;
                if ((dept=="HR"|| dept=="Accts"))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(ErrorMessage ?? "dept should be HR or Accts ");

        }
    }
}
