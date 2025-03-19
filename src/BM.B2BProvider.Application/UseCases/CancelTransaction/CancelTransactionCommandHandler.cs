using BM.B2BProvider.Domain;
using BM.B2BProvider.Infrastructure.Factories;
using MediatR;

namespace BM.B2BProvider.Application.UseCases.CancelTransaction;

public class CancelTransactionCommandHandler : IRequestHandler<CancelTransactionCommand>
{
    public async Task Handle(CancelTransactionCommand request, CancellationToken cancellationToken)
    {
        IB2BProvider provider = B2BProviderFactory.GetProvider(request.B2BType);

        await provider.CancelTransactionAsync(request.ToEntityRequest());
    }
}