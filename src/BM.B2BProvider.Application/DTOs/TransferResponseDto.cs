using BM.B2BProvider.Domain.Entities.Transfer;

namespace BM.B2BProvider.Application.DTOs;

public record TransferResponseDto
{
    public string ProfileId { get; set; } = string.Empty;
    public string Currency { get; set; } = string.Empty;
    public decimal Balance { get; set; }
}

public static class TransferResponseDtoExtensions
{
    public static TransferResponseDto ToResponseDto(this TransferResponse transferResponse)
    {
        return new TransferResponseDto
        {
            ProfileId = transferResponse.ProfileId,
            Currency = transferResponse.Currency,
            Balance = transferResponse.Balance
        };
    }
}