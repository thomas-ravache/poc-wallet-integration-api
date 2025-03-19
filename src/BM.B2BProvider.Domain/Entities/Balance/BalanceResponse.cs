namespace BM.B2BProvider.Domain.Entities.Balance;

public class BalanceResponse
{
    public string ProfileId { get; set; } = string.Empty;
    public string Currency { get; set; } = string.Empty;
    public decimal Balance { get; set; }
}