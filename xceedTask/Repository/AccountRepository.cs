using xceedTask.Controllers;
using xceedTask.Models;

namespace xceedTask.Repository
{
    public class AccountRepository : IRepository<Account>
    {
        MyContext _context;
        public AccountRepository(MyContext context)
        {

            _context = context;

        }
        public void Delete(int id)
        {
            Account oldAccount = GetById(id);

            _context.Accounts.Remove(oldAccount);
        }

        public List<Account> GetAll()
        {
            return _context.Accounts.ToList();
        }

        public Account GetById(int id)
        {
            return _context.Accounts.FirstOrDefault(d => d.Id == id);
        }

        public void Insert(Account obj)
        {
            _context.Accounts.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(int id, Account obj)
        {
            Account oldAcc= GetById(id);
            oldAcc.Name=obj.Name;
            
        }
    }
}
