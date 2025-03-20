using BM.B2BProvider.Application.Interfaces.Factories;
using BM.B2BProvider.Domain;
using MediatR;

namespace BM.B2BProvider.Application.UseCases.CancelTransaction;

public class CancelTransactionCommandHandler : IRequestHandler<CancelTransactionCommand>
{
    private readonly IB2BProviderFactory _providerFactory;

    public CancelTransactionCommandHandler(IB2BProviderFactory providerFactory)
    {
        _providerFactory = providerFactory;
    }

    public async Task Handle(CancelTransactionCommand request, CancellationToken cancellationToken)
    {
        IB2BProvider provider = _providerFactory.GetProvider(request.B2BType);

        await provider.CancelTransactionAsync(request.ToEntityRequest());
    }
}