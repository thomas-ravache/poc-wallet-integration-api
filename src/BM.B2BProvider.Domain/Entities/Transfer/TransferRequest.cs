namespace BM.B2BProvider.Domain.Entities.Transfer;

public class TransferRequest
{
    public string VendorCode { get; set; } = string.Empty;
    public string SessionId { get; set; } = string.Empty;
    public string ProfileId { get; set; } = string.Empty;
    public string VendorGameId { get; set; } = string.Empty;
    public string OperationType { get; set; } = string.Empty; // "bet" or "win"
    public string TransactionId { get; set; } = string.Empty;
    public string RoundId { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Currency { get; set; } = string.Empty;
    public decimal JackpotContribution { get; set; }
    public bool IsRoundFinished { get; set; }
}