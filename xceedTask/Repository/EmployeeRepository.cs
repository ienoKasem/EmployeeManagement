using xceedTask.Models;

namespace xceedTask.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        MyContext context;
        public EmployeeRepository(MyContext _context)
        {
            context = _context;
            
        }

        public void Delete(int id)
        {
            Employee oldEmp = GetById(id);

            context.Employees.Remove(oldEmp);
        }

        public List<Employee> GetAll()
        {
            return context.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return context.Employees.FirstOrDefault(d => d.Id == id);
        }

        public void Insert(Employee obj)
        {
            context.Employees.Add(obj);
        }

      

        public void Update(int id, Employee obj)
        {
            Employee oldEmp = GetById(id);

            oldEmp.Name = obj.Name;
            oldEmp.DateOfBirth = obj.DateOfBirth;
            oldEmp.NationalID = obj.NationalID;
            oldEmp.Aid = obj.Aid;
        }
        public void Save()
        {
            context.SaveChanges();
        }

        public List<LineOFBusiness> GetByAccID(int Aid)
        {
            List<LineOFBusiness> lof = context.LineOFBusinesses.Where(e => e.Aid ==Aid ).ToList();
            return lof;
             
        }

        public Employee GetByNatId(decimal Nid)
        {
            return context.Employees.Where(p => p.NationalID == Nid).FirstOrDefault();
        }
    }
}
