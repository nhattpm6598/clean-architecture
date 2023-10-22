using BE.Eco.PaymentProcessing.Application.Repositories.Common.BaseConnection;

namespace BE.Eco.PaymentProcessing.Application.Repositories.Common
{
    public interface IUnitOfWork
    {
        IDBMasterConnectBaseRepositories DBMaster { get; }

        IDBPartnerConnectBaseRepositories DBPartner { get; }
    }
}
