namespace WebAPIBlazorConsumer.Services
{
    public interface IServices<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task Insert(T obj);
        Task Update(int id ,T obj);
        Task Delete(int id);
    }
}
