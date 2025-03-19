using BM.B2BProvider.Application.DTOs;
using BM.B2BProvider.Domain.Entities.Transfer;
using MediatR;

namespace BM.B2BProvider.Application.UseCases.PerformDebit;

public class PerformDebitCommand : RequestBase, IRequest<TransferResponseDto>
{
    public string VendorCode { get; set; } = string.Empty;
    public string SessionId { get; set; } = string.Empty;
    public string ProfileId { get; set; } = string.Empty;
    public string VendorGameId { get; set; } = string.Empty;
    public string TransactionId { get; set; } = string.Empty;
    public string RoundId { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Currency { get; set; } = string.Empty;
    public decimal JackpotContribution { get; set; }
    public bool IsRoundFinished { get; set; }

    public TransferRequest ToEntityRequest()
    {
        return new TransferRequest
        {
            VendorCode = VendorCode,
            SessionId = SessionId,
            ProfileId = ProfileId,
            VendorGameId = VendorGameId,
            TransactionId = TransactionId,
            RoundId = RoundId,
            Amount = Amount,
            Currency = Currency,
            JackpotContribution = JackpotContribution,
            IsRoundFinished = IsRoundFinished
        };
    }
}