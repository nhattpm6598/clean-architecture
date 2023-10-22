using System.Data;

namespace BE.Eco.PaymentProcessing.Application.Repositories.Common
{
    public interface IDBBaseRepositories : IDisposable
    {
        IDbConnection Connection { get; }

        IDbTransaction? Transaction { get; }

        void BeginTransaction();

        void Commit();

        void Rollback();

        void ClearRepos();
    }
}
