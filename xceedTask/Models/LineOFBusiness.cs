using System.ComponentModel.DataAnnotations.Schema;

namespace xceedTask.Models
{
    public class LineOFBusiness
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Account")]
        public int Aid { get; set; }

        public virtual Account? Account { get; set; }

        public virtual List<EmployeeLineOfBusiness>? EmployeeLineOfBusinesss { get; set; }

    }
}
