using BM.B2BProvider.Domain.Entities.Balance;

namespace BM.B2BProvider.Application.DTOs;

public record BalanceResponseDto
{
    public string ProfileId { get; set; } = string.Empty;
    public string Currency { get; set; } = string.Empty;
    public decimal Balance { get; set; }
}

public static class BalanceResponseDtoExtensions
{
    public static BalanceResponseDto ToResponseDto(this BalanceResponse balanceResponse)
    {
        return new BalanceResponseDto
        {
            ProfileId = balanceResponse.ProfileId,
            Currency = balanceResponse.Currency,
            Balance = balanceResponse.Balance
        };
    }
}