using BE.Eco.PaymentProcessing.Application.Repositories.Common.BaseConnection;
using BE.Eco.PaymentProcessing.Application.Repositories.DBMaster;
using BE.Eco.PaymentProcessing.Domain.Constants.Enums;
using BE.Eco.PaymentProcessing.Infrastructure.Common.SqlConfig.Connection;
using BE.Eco.PaymentProcessing.Infrastructure.Repositories.Common.BaseConnect;
using BE.Eco.PaymentProcessing.Infrastructure.Repositories.DBMaster;
using System.Data;

namespace BE.Eco.PaymentProcessing.Infrastructure.Repositories.Common.Base
{
    public class DBMasterConnectBaseRepositories : DBBaseRespository, IDBMasterConnectBaseRepositories
    {
        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="connectionFactory"></param>
        public DBMasterConnectBaseRepositories(IDBMultiConnectionFactory connectionFactory) : base(connectionFactory)
        {
            _connection = connectionFactory.CreateDbConnection(DatabaseInstance.ECO_MAT);
        }

        /// <summary>
        /// ClearRepos
        /// </summary>
        public override void ClearRepos()
        {
            _paymentTokenRepository = null;
        }

        /// <summary>
        /// _paymentTokenRepository
        /// </summary>
        private IPaymentTokenRepository? _paymentTokenRepository;

        /// <summary>
        /// PaymentToken
        /// </summary>
        public IPaymentTokenRepository PaymentToken => _paymentTokenRepository ?? new PaymentTokenRepository(_connection, _transaction);
    }
}
