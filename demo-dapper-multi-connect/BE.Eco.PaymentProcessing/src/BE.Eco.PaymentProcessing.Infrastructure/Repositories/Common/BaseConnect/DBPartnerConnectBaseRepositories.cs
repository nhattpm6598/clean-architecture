using BE.Eco.PaymentProcessing.Application.Repositories.Common.BaseConnection;
using BE.Eco.PaymentProcessing.Application.Repositories.DBPartner;
using BE.Eco.PaymentProcessing.Domain.Constants.Enums;
using BE.Eco.PaymentProcessing.Infrastructure.Common.SqlConfig.Connection;
using BE.Eco.PaymentProcessing.Infrastructure.Repositories.Common.BaseConnect;
using BE.Eco.PaymentProcessing.Infrastructure.Repositories.DBPartner;
using System.Data;

namespace BE.Eco.PaymentProcessing.Infrastructure.Repositories.Common.Base
{
    public class DBPartnerConnectBaseRepositories : DBBaseRespository, IDBPartnerConnectBaseRepositories
    {
        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="connectionFactory"></param>
        public DBPartnerConnectBaseRepositories(IDBMultiConnectionFactory connectionFactory) : base(connectionFactory)
        {
            _connection = connectionFactory.CreateDbConnection(DatabaseInstance.ECO_MER);
        }

        /// <summary>
        /// ClearRepos
        /// </summary>
        public override void ClearRepos()
        {
            _partnerWalletHistoryRepository = null;
        }

        /// <summary>
        /// _partnerWalletHistoryRepository
        /// </summary>
        private IPartnerWalletHistoryRepository? _partnerWalletHistoryRepository;

        /// <summary>
        /// PartnerWalletHistory
        /// </summary>
        public IPartnerWalletHistoryRepository PartnerWalletHistory => _partnerWalletHistoryRepository ?? new PartnerWalletHistoryRepository(_connection, _transaction);

    }
}
