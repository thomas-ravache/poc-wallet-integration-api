using BM.B2BProvider.Application.DTOs;
using BM.B2BProvider.Domain.Entities.Balance;
using BM.B2BProvider.Infrastructure.Factories;
using MediatR;

namespace BM.B2BProvider.Application.UseCases.GetBalance;

public class GetBalanceCommandHandler : IRequestHandler<GetBalanceCommand, BalanceResponseDto>
{
    public async Task<BalanceResponseDto> Handle(GetBalanceCommand request, CancellationToken cancellationToken)
    {
        var provider = B2BProviderFactory.GetProvider(request.B2BType);

        BalanceResponse response = await provider.GetBalanceAsync(request.ToEntityRequest());

        return response.ToResponseDto();
    }
}
