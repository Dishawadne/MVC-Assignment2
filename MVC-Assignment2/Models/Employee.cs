using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_Assignment2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = " Name is must")]
        [RegularExpression("[a-zA-Z ]+", ErrorMessage = "Only alphabets are allowed")]
        [MinLength(15, ErrorMessage = "Min 15 characters needed")]
        
        public string Name { get; set; }


        [Validator]
        public DateTime DOB { get; set; }

        [DateOfJoiningValidator]
        public DateTime Doj { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [NotMapped]
        [DataType(DataType.Password)]
        public string ReTypePassword { get; set; }

       
        [Range(12000, 60000, ErrorMessage = "Range is 12000 to 60000")]
        public int? salary {  get; set; }

        [DeptValidator]
        public string Dept { get; set; }

    }
}

