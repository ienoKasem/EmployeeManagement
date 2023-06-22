using xceedTask.Models;

namespace xceedTask.Repository
{
    public interface IEmployeeRepository: IRepository<Employee>
    {
        List<LineOFBusiness> GetByAccID(int Aid);
        Employee GetByNatId(decimal Nid);
        
    }
}
