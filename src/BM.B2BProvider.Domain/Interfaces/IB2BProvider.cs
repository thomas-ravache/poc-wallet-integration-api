using  BM.B2BProvider.Domain.Entities.Balance;
using  BM.B2BProvider.Domain.Entities.Transfer;
using  BM.B2BProvider.Domain.Entities.CancelTransaction;

namespace BM.B2BProvider.Domain;

public interface IB2BProvider
{
    Task<BalanceResponse> GetBalanceAsync(BalanceRequest request);
    Task<TransferResponse> CreditAsync(TransferRequest request);
    Task<TransferResponse> DebitAsync(TransferRequest request);
    Task CancelTransactionAsync(CancelTransactionRequest request);
}