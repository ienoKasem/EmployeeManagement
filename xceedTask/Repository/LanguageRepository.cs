using xceedTask.Models;

namespace xceedTask.Repository
{
    public class LanguageRepository : IRepository<Language>
    {
        MyContext _context;
        public LanguageRepository(MyContext context)
        {

            _context = context;

        }
        public void Delete(int id)
        {
            Language oldLang = GetById(id);

            _context.Languages.Remove(oldLang);

        }

        public List<Language> GetAll()
        {
            return _context.Languages.ToList();
        }

        public Language GetById(int id)
        {
            return _context.Languages.FirstOrDefault(d => d.Id == id);
        }

        public void Insert(Language obj)
        {
             _context.Languages.Add(obj);
        }

     
        public void Update(int id, Language obj)
        {
            Language oldLang = GetById(id);
            oldLang.Name=obj.Name;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
