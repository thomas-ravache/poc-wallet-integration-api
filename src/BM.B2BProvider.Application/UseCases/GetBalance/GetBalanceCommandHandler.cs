using BM.B2BProvider.Application.DTOs;
using BM.B2BProvider.Application.Interfaces.Factories;
using BM.B2BProvider.Domain.Entities.Balance;
using MediatR;

namespace BM.B2BProvider.Application.UseCases.GetBalance;

public class GetBalanceCommandHandler : IRequestHandler<GetBalanceCommand, BalanceResponseDto>
{
    private readonly IB2BProviderFactory _providerFactory;

    public GetBalanceCommandHandler(IB2BProviderFactory providerFactory)
    {
        _providerFactory = providerFactory;
    }

    public async Task<BalanceResponseDto> Handle(GetBalanceCommand request, CancellationToken cancellationToken)
    {
        var provider = _providerFactory.GetProvider(request.B2BType);

        BalanceResponse response = await provider.GetBalanceAsync(request.ToEntityRequest());

        return response.ToResponseDto();
    }
}
