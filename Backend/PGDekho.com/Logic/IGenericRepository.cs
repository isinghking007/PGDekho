namespace PGDekho.com.Logic
{
    public interface IGenericRepository <T> where T : class
    {
        IEnumerable<T> ShowAllRecords();

        void Add(T entity);
        
        void Update(T entity);
        void Delete(T entity);

    }
}
