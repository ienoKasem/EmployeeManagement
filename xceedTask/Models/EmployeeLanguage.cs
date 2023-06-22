using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xceedTask.Models
{
    public class EmployeeLanguage
    {
        [Key]
        [ForeignKey("Employee")]
        public int EId { get; set; }
        [Key]
        [ForeignKey("Language")]
        public int LId { get; set; }

        public string? Oral { get; set; }
        public string? Writing { get; set; }
        public string? Speaking { get; set; }
        public string? Listening { get; set; }

        public virtual Employee? Employee { get; set; }
        public virtual Language? Language { get; set; }






    }
}
