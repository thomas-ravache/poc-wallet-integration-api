using BM.B2BProvider.Domain.Entities.CancelTransaction;
using MediatR;

namespace BM.B2BProvider.Application.UseCases.CancelTransaction;

public class CancelTransactionCommand : RequestBase, IRequest
{
    public string VendorCode { get; set; } = string.Empty;
    public string SessionId { get; set; } = string.Empty;
    public string ProfileId { get; set; } = string.Empty;
    public string VendorGameId { get; set; } = string.Empty;
    public string TransactionId { get; set; } = string.Empty;

    public CancelTransactionRequest ToEntityRequest()
    {
        return new CancelTransactionRequest
        {
            VendorCode = VendorCode,
            SessionId = SessionId,
            ProfileId = ProfileId,
            VendorGameId = VendorGameId,
            TransactionId = TransactionId
        };
    }
}