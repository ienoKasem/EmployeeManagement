using Microsoft.EntityFrameworkCore.Migrations.Operations;
using xceedTask.Models;

namespace xceedTask.Repository
{
    public interface IEmployeeLOFRepository
    {
        void Insert(EmployeeLineOfBusiness elob);
        public void Delete(int id);
        void Save();

    }
}
