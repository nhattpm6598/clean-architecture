using BE.Eco.PaymentProcessing.Application.Repositories.Common;
using Dapper.Contrib.Extensions;
using System.Data;

namespace BE.Eco.PaymentProcessing.Infrastructure.Repositories.Common
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected IDbConnection _connection;
        protected IDbTransaction? _transaction;

        public GenericRepository(IDbConnection connection, IDbTransaction? transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public async Task<bool> Delete(TEntity entity)
        {
            bool deleted = await SqlMapperExtensions.DeleteAsync<TEntity>(_connection, entity, _transaction);
            return deleted;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            IEnumerable<TEntity> result = await SqlMapperExtensions.GetAllAsync<TEntity>(connection: _connection, transaction: _transaction);
            return result;
        }

        public async Task<TEntity> GetAsync(int id)
        {
            TEntity result = await SqlMapperExtensions.GetAsync<TEntity>(_connection, id, _transaction);
            return result;
        }

        public async Task<long> Insert(TEntity entity)
        {
            long added = await SqlMapperExtensions.InsertAsync<TEntity>(_connection, entity, _transaction);
            return added;
        }

        public async Task<bool> Update(TEntity entity)
        {
            bool updated = await SqlMapperExtensions.UpdateAsync<TEntity>(_connection, entity, _transaction);
            return updated;
        }
    }
}
