using BE.Eco.PaymentProcessing.Application.Repositories.DBMaster;

namespace BE.Eco.PaymentProcessing.Application.Repositories.Common.BaseConnection
{
    public interface IDBMasterConnectBaseRepositories : IDBBaseRepositories
    {
        IPaymentTokenRepository PaymentToken { get; }
    }

}
