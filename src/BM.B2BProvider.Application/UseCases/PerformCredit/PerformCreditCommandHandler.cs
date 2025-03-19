using BM.B2BProvider.Application.DTOs;
using BM.B2BProvider.Domain;
using BM.B2BProvider.Domain.Entities.Transfer;
using BM.B2BProvider.Infrastructure.Factories;
using MediatR;

namespace BM.B2BProvider.Application.UseCases.PerformCredit;

public class PerformCreditCommandHandler : IRequestHandler<PerformCreditCommand, TransferResponseDto>
{
    public async Task<TransferResponseDto> Handle(PerformCreditCommand request, CancellationToken cancellationToken)
    {
        TransferRequest entity = request.ToEntityRequest();
        entity.OperationType = Constants.Win;

        var provider = B2BProviderFactory.GetProvider(request.B2BType);

        TransferResponse response = await provider.CreditAsync(request.ToEntityRequest());

        return response.ToResponseDto();
    }
}