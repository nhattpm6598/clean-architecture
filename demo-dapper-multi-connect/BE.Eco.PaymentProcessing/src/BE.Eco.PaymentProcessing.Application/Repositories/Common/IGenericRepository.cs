namespace BE.Eco.PaymentProcessing.Application.Repositories.Common
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetAsync(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<long> Insert(TEntity entity);

        Task<bool> Update(TEntity entity);

        Task<bool> Delete(TEntity entity);
    }
}
