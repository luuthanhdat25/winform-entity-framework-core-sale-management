namespace AutomobileWinform.Repository;

public interface IRepository<T, I>
{
    IEnumerable<T> ListAll();
    bool InsertObject(T obj);
    bool DeleteById(I id);
    bool UpdateByObject(T obj);
}