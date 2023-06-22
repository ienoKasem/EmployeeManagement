using Microsoft.AspNetCore.Cors.Infrastructure;

namespace xceedTask.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<EmployeeLanguage>? EmployeeLanguages { get; set; }
        

    }
}
