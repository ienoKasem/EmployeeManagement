using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xceedTask.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Column(TypeName = "decimal(20,0)")]
        [RegularExpression("@\"^\\d{14}$\""
           , ErrorMessage = "You Must Type 14 Number")]
        public decimal NationalID { get; set; }

        [RegularExpression("(/^[A-Za-z]+$/)"
            , ErrorMessage = "You Must Tybe only Text")]
        public string Name { get; set; }

        [ForeignKey("Account")]
        public int Aid { get; set; }


        public DateTime DateOfBirth { get; set; }

        [NotMapped]
        [Range(18,999)]
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth > today.AddYears(-age))
                {
                    age--;
                }
                return age;
            }
        }

        public virtual Account? Account { get; set; }
        public virtual List<EmployeeLanguage>? EmployeeLanguages { get; set; }
        public virtual List<EmployeeLineOfBusiness>? EmployeeLineOfBusinesss { get; set; }
       
        



    }
}
