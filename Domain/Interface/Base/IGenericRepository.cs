namespace Domain.Interface.Base
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        Task<T> GetByIdAsync(Guid id);

        Task<T> GetByIdAsync(long id);

        Task<IReadOnlyList<T>> ListAllAsync();

        Task<T> AddAsync(T entity);

        Task<List<T>> AddRangeAsync(List<T> entity);

        Task<List<T>> UpdateRangeAsync(List<T> entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task DeleteRangeAsync(List<T> entity);

    }
}
