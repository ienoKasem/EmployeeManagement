using xceedTask.Models;

namespace xceedTask.Repository
{
    public class EmployeeLOFRepository : IEmployeeLOFRepository
    {
        MyContext context;
        public EmployeeLOFRepository(MyContext context)
        {

            this.context = context;

        }
        public void Insert(EmployeeLineOfBusiness elob)
        {
            context.EmployeeLineOfBusinesses.Add(elob);
        }
        public List<EmployeeLineOfBusiness> GetAllById(int id)
        {
            return context.EmployeeLineOfBusinesses.Where(p=>p.Eid==id).ToList();
        }
        public void Delete(int id)
        {
            List<EmployeeLineOfBusiness> oldEmp = GetAllById(id);
            foreach (var item in oldEmp)
            {

                context.EmployeeLineOfBusinesses.Remove(item);
            }
            
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
