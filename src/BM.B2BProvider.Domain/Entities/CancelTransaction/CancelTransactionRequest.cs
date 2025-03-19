namespace BM.B2BProvider.Domain.Entities.CancelTransaction;

public class CancelTransactionRequest
{
    public string VendorCode { get; set; } = string.Empty;
    public string SessionId { get; set; } = string.Empty;
    public string ProfileId { get; set; } = string.Empty;
    public string VendorGameId { get; set; } = string.Empty;
    public string TransactionId { get; set; } = string.Empty;
}