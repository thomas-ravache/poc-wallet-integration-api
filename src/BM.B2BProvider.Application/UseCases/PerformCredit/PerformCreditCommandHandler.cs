using BM.B2BProvider.Application.DTOs;
using BM.B2BProvider.Application.Interfaces.Factories;
using BM.B2BProvider.Domain;
using BM.B2BProvider.Domain.Entities.Transfer;
using MediatR;

namespace BM.B2BProvider.Application.UseCases.PerformCredit;

public class PerformCreditCommandHandler : IRequestHandler<PerformCreditCommand, TransferResponseDto>
{
    private readonly IB2BProviderFactory _providerFactory;

    public PerformCreditCommandHandler(IB2BProviderFactory providerFactory)
    {
        _providerFactory = providerFactory;
    }


    public async Task<TransferResponseDto> Handle(PerformCreditCommand request, CancellationToken cancellationToken)
    {
        TransferRequest entity = request.ToEntityRequest();
        entity.OperationType = Constants.Win;

        var provider = _providerFactory.GetProvider(request.B2BType);

        TransferResponse response = await provider.CreditAsync(request.ToEntityRequest());

        return response.ToResponseDto();
    }
}