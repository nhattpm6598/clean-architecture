using BE.Eco.PaymentProcessing.Application.Repositories.Common;
using BE.Eco.PaymentProcessing.Domain.Constants.Enums;
using BE.Eco.PaymentProcessing.Infrastructure.Common.SqlConfig.Connection;
using System.Data;

namespace BE.Eco.PaymentProcessing.Infrastructure.Repositories.Common.BaseConnect
{
    public abstract class DBBaseRespository : IDBBaseRepositories
    {
        protected IDbConnection _connection;

        protected IDbTransaction? _transaction;

        public DBBaseRespository(IDBMultiConnectionFactory connectionFactory)
        {
            _connection = connectionFactory.CreateDbConnection(DatabaseInstance.ECO_MAT);
        }

        public IDbConnection Connection { get { return _connection; } }

        public IDbTransaction? Transaction { get { return _transaction; } }

        /// <summary>
        /// BeginTransaction
        /// </summary>
        public void BeginTransaction()
        {
            if (_transaction == null)
            {
                _transaction = _connection.BeginTransaction();
            }
        }

        /// <summary>
        /// ClearRepos
        /// </summary>
        public virtual void ClearRepos()
        {
            // throw new NotImplementedException();
        }

        /// <summary>
        /// Commit
        /// </summary>
        public void Commit()
        {
            try
            {
                if (_transaction != null)
                {
                    _transaction.Commit();
                }
            }
            catch
            {
                _transaction?.Rollback();
                throw;
            }
        }

        /// <summary>
        /// Rollback
        /// </summary>
        public void Rollback()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
            }
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool _disposed;

        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="disposning"></param>
        protected virtual void Dispose(bool disposning)
        {
            if (this._disposed)
            {
                return;
            }

            if (disposning)
            {
                ClearRepos();
                if (_transaction != null) _transaction.Dispose();
                if (_connection != null) _connection.Dispose();
            }

            this._disposed = true;
        }
    }
}
