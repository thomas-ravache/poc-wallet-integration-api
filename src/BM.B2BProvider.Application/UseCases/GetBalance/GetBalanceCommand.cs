using BM.B2BProvider.Application.DTOs;
using BM.B2BProvider.Domain.Entities.Balance;
using MediatR;

namespace BM.B2BProvider.Application.UseCases.GetBalance;

public class GetBalanceCommand : RequestBase, IRequest<BalanceResponseDto>
{
    public string VendorCode { get; set; } = string.Empty;
    public string SessionId { get; set; } = string.Empty;
    public string ProfileId { get; set; } = string.Empty;
    public string VendorGameId { get; set; } = string.Empty;

    public BalanceRequest ToEntityRequest()
    {
        return new BalanceRequest
        {
            VendorCode = VendorCode,
            SessionId = SessionId,
            ProfileId = ProfileId,
            VendorGameId = VendorGameId
        };
    }
}