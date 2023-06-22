using xceedTask.Models;

namespace xceedTask.Repository
{
    public class EmployeeLanguageRepository:IEmployeeLanguage
    {
        MyContext _context;
        public EmployeeLanguageRepository(MyContext context) 
        {
            _context = context;
        }

        public void Delete(int id)
        {
            EmployeeLanguage oldLFB = GetById(id);

            _context.EmployeeLanguages.Remove(oldLFB);
        }

        public List<EmployeeLanguage> GetAll()
        {
            return _context.EmployeeLanguages.ToList();
        }

        public EmployeeLanguage GetById(int Eid,int Lid)
        {
            return _context.EmployeeLanguages.FirstOrDefault(d => d.EId == Eid&&Lid==d.LId);
        }

        public EmployeeLanguage GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(EmployeeLanguage obj)
        {
            _context.EmployeeLanguages.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(int id, EmployeeLanguage obj)
        {
            EmployeeLanguage oldAcc = GetById(id);
            oldAcc.EId = obj.EId;
            oldAcc.LId = obj.LId;
            oldAcc.Oral = obj.Oral;
            oldAcc.Writing = obj.Writing;
            oldAcc.Speaking = obj.Speaking;
            oldAcc.Listening = obj.Listening;
        }

        
    }
}
