using BE.Eco.PaymentProcessing.Application.Repositories.DBPartner;
using BE.Eco.PaymentProcessing.Domain.Entities.EcoMer;
using BE.Eco.PaymentProcessing.Infrastructure.Repositories.Common;
using Dapper;
using System.Data;

namespace BE.Eco.PaymentProcessing.Infrastructure.Repositories.DBPartner
{
    public class PartnerWalletHistoryRepository : GenericRepository<PartnerWalletHistoryEntities>, IPartnerWalletHistoryRepository
    {
        public PartnerWalletHistoryRepository(IDbConnection connection, IDbTransaction? transaction) : base(connection, transaction)
        {
        }

        public async Task DemoConnect()
        {
            string sql = "  SELECT * FROM [ECO_MAT].[dbo].[tblPaymentToken]";

            var demo = await SqlMapper.QueryAsync<object>(cnn: _connection, sql: sql, transaction: _transaction);
        }
    }
}
