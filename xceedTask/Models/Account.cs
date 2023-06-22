namespace xceedTask.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Employee> Employees { get; set; }
        public virtual List<LineOFBusiness> LineOFBusinesses { get; set; }



    }
}
