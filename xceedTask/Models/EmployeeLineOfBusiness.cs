using System.ComponentModel.DataAnnotations;

namespace xceedTask.Models
{
    public class EmployeeLineOfBusiness
    {
        [Key]
        public int Eid { get; set; }
        [Key]
        public int LofId { get; set; }


        public virtual Employee? Employee { get; set; }
        public virtual LineOFBusiness? LineOFBusiness { get; set; }

    }
}
