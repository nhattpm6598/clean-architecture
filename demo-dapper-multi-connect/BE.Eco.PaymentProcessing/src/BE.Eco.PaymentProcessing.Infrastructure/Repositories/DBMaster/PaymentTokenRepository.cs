using BE.Eco.PaymentProcessing.Application.Repositories.DBMaster;
using BE.Eco.PaymentProcessing.Domain.Entities.EcoMat;
using BE.Eco.PaymentProcessing.Infrastructure.Repositories.Common;
using Dapper;
using System.Data;

namespace BE.Eco.PaymentProcessing.Infrastructure.Repositories.DBMaster
{
    public class PaymentTokenRepository : GenericRepository<PaymentTokenEntities>, IPaymentTokenRepository
    {

        public PaymentTokenRepository(IDbConnection connection, IDbTransaction? transaction) : base(connection, transaction)
        {
        }

        public async Task DemoConnect()
        {
            string sql = "  SELECT * FROM [ECO_MAT].[dbo].[tblPaymentToken]";

            var demo = await SqlMapper.QueryAsync<object>(cnn: _connection, sql: sql, transaction: _transaction);
        }
    }
}
