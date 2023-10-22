using BE.Eco.PaymentProcessing.Application.Repositories.Common;
using BE.Eco.PaymentProcessing.Domain.Entities.EcoMat;

namespace BE.Eco.PaymentProcessing.Application.Repositories.DBMaster
{
    public interface IPaymentTokenRepository : IGenericRepository<PaymentTokenEntities>
    {
        Task DemoConnect();
    }
}
