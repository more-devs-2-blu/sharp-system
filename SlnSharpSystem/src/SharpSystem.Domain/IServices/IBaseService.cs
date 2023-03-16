namespace SharpSystem.Domain.IServices
{
    public interface IBaseService<T> where T : class
    {
        List<T> FindAll();
        Task<T> FindById(int id);
        Task<int> Save(T entity);
        Task<int> Delete(int id);
    }
}
