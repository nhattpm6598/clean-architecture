using BE.Eco.PaymentProcessing.Application.Repositories.Common;
using BE.Eco.PaymentProcessing.Domain.Entities.EcoMer;

namespace BE.Eco.PaymentProcessing.Application.Repositories.DBPartner
{
    public interface IPartnerWalletHistoryRepository : IGenericRepository<PartnerWalletHistoryEntities>
    {
        Task DemoConnect();

    }
}
