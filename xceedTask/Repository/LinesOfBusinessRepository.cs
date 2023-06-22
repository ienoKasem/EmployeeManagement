using Microsoft.EntityFrameworkCore;
using xceedTask.Models;

namespace xceedTask.Repository
{
    public class LinesOfBusinessRepository:IRepository<LineOFBusiness>
    {
        MyContext _context;
        public LinesOfBusinessRepository(MyContext context) {
        
        _context= context;
        
        }

        public void Delete(int id)
        {
            LineOFBusiness oldLFB = GetById(id);

            _context.LineOFBusinesses.Remove(oldLFB);
        }

        public List<LineOFBusiness> GetAll()
        {
            return _context.LineOFBusinesses.ToList();
        }

        public LineOFBusiness GetById(int id)
        {
            return _context.LineOFBusinesses.FirstOrDefault(d => d.Id == id);
        }

        public void Insert(LineOFBusiness obj)
        {
            _context.LineOFBusinesses.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }


        public void Update(int id, LineOFBusiness obj)
        {
            LineOFBusiness oldAcc = GetById(id);
            oldAcc.Name = obj.Name;
            oldAcc.Aid = obj.Aid;
        }
    }
}
