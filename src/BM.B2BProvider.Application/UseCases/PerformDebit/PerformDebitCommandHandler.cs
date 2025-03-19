using BM.B2BProvider.Application.DTOs;
using BM.B2BProvider.Domain;
using BM.B2BProvider.Domain.Entities.Transfer;
using BM.B2BProvider.Infrastructure.Factories;
using MediatR;

namespace BM.B2BProvider.Application.UseCases.PerformDebit;

public class PerformDebitCommandHandler : IRequestHandler<PerformDebitCommand, TransferResponseDto>
{
    public async Task<TransferResponseDto> Handle(PerformDebitCommand request, CancellationToken cancellationToken)
    {
        TransferRequest entity = request.ToEntityRequest();
        entity.OperationType = Constants.Bet;

        var provider = B2BProviderFactory.GetProvider(request.B2BType);

        TransferResponse response = await provider.DebitAsync(entity);

        return response.ToResponseDto();
    }
}