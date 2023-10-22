using BE.Eco.PaymentProcessing.Application.Repositories.Common;
using BE.Eco.PaymentProcessing.Application.Repositories.Common.BaseConnection;
using BE.Eco.PaymentProcessing.Infrastructure.Common.SqlConfig.Connection;
using BE.Eco.PaymentProcessing.Infrastructure.Repositories.Common.Base;

namespace BE.Eco.PaymentProcessing.Infrastructure.Repositories.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDBMultiConnectionFactory _dBMultiConnectionFactory;

        public UnitOfWork(IDBMultiConnectionFactory dBMultiConnectionFactory)
        {
            _dBMultiConnectionFactory = dBMultiConnectionFactory;
        }

        #region DBMaster

        private readonly IDBMasterConnectBaseRepositories? _dbMaster;

        public IDBMasterConnectBaseRepositories DBMaster => _dbMaster ?? new DBMasterConnectBaseRepositories(_dBMultiConnectionFactory);

        #endregion

        #region DBPartnet

        private readonly IDBPartnerConnectBaseRepositories? _dbPartner;

        public IDBPartnerConnectBaseRepositories DBPartner => _dbPartner ?? new DBPartnerConnectBaseRepositories(_dBMultiConnectionFactory);

        #endregion 
    }
}
