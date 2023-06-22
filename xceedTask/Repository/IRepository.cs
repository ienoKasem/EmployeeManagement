namespace xceedTask.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Insert(T obj);
        void Update(int id, T obj);
        void Delete(int id);
        void Save();

    }
}
