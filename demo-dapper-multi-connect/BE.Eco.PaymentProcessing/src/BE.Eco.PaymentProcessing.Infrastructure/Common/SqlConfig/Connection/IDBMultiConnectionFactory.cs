using BE.Eco.PaymentProcessing.Domain.Constants.Enums;
using System.Data;

namespace BE.Eco.PaymentProcessing.Infrastructure.Common.SqlConfig.Connection
{
    public interface IDBMultiConnectionFactory
    {
        IDbConnection CreateDbConnection(DatabaseInstance databaseInstance);
    }
}
