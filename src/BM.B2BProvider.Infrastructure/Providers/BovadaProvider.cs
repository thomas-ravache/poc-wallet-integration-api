using BM.B2BProvider.Domain;
using BM.B2BProvider.Domain.Entities.Balance;
using BM.B2BProvider.Domain.Entities.CancelTransaction;
using BM.B2BProvider.Domain.Entities.Transfer;

namespace BM.B2BProvider.Infrastructure.Providers;

public class BovadaProvider : IB2BProvider
{
    public Task CancelTransactionAsync(CancelTransactionRequest request)
    {
        return Task.CompletedTask;
    }

    public Task<TransferResponse> CreditAsync(TransferRequest request)
    {
        return Task.FromResult(new TransferResponse
        {
            ProfileId = request.ProfileId,
            Currency = request.Currency,
            Balance = request.Amount,
            WalletTransactionId = Guid.NewGuid().ToString()
        });
    }

    public Task<TransferResponse> DebitAsync(TransferRequest request)
    {
        return Task.FromResult(new TransferResponse
        {
            ProfileId = request.ProfileId,
            Currency = request.Currency,
            Balance = request.Amount,
            WalletTransactionId = Guid.NewGuid().ToString()
        });
    }

    public Task<BalanceResponse> GetBalanceAsync(BalanceRequest request)
    {
        
        return Task.FromResult(new BalanceResponse
        {
            ProfileId = request.ProfileId,
            Currency = "USD",
            Balance = 1000
        });
    }
}