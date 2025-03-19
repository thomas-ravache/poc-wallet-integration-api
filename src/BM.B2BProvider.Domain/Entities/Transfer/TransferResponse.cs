namespace BM.B2BProvider.Domain.Entities.Transfer;

public class TransferResponse
{
    public string ProfileId { get; set; } = string.Empty;
    public string Currency { get; set; } = string.Empty;
    public decimal Balance { get; set; }
    public string WalletTransactionId { get; set; } = string.Empty;
}