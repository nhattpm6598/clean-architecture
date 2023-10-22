using BE.Eco.PaymentProcessing.Application.Repositories.DBPartner;

namespace BE.Eco.PaymentProcessing.Application.Repositories.Common.BaseConnection
{
    public interface IDBPartnerConnectBaseRepositories : IDBBaseRepositories
    {
        IPartnerWalletHistoryRepository PartnerWalletHistory { get; }
    }
}
