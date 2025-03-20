using BM.B2BProvider.Application.DTOs;
using BM.B2BProvider.Application.Interfaces.Factories;
using BM.B2BProvider.Domain;
using BM.B2BProvider.Domain.Entities.Transfer;
using MediatR;

namespace BM.B2BProvider.Application.UseCases.PerformDebit;

public class PerformDebitCommandHandler : IRequestHandler<PerformDebitCommand, TransferResponseDto>
{
    private readonly IB2BProviderFactory _providerFactory;

    public PerformDebitCommandHandler(IB2BProviderFactory providerFactory)
    {
        _providerFactory = providerFactory;
    }


    public async Task<TransferResponseDto> Handle(PerformDebitCommand request, CancellationToken cancellationToken)
    {
        TransferRequest entity = request.ToEntityRequest();
        entity.OperationType = Constants.Bet;

        var provider = _providerFactory.GetProvider(request.B2BType);

        TransferResponse response = await provider.DebitAsync(entity);

        return response.ToResponseDto();
    }
}