using xceedTask.Models;
using xceedTask.Repository;

namespace xceedTask.ViewModel
{
    public class TestViewModel
    {
       
    
        
        public List<Employee> Employees { get; set; }
        public List<Language> Languages { get; set; }
        public List<EmployeeLanguage> EmployeeLanguages { get; set; }
        public List<Account> Accounts { get; set; }
        public List<LineOFBusiness> LineOFBusinesses { get; set; }
    }
}
