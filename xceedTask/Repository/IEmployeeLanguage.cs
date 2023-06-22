using xceedTask.Models;

namespace xceedTask.Repository
{
    public interface IEmployeeLanguage:IRepository<EmployeeLanguage>
    {
        EmployeeLanguage GetById(int Eid,int Lid);

    }
}
