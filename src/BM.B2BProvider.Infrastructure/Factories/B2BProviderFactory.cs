using BM.B2BProvider.Domain;
using BM.B2BProvider.Domain.Enums;
using BM.B2BProvider.Infrastructure.Providers;
using BM.B2BProvider.Application.Interfaces.Factories;

namespace BM.B2BProvider.Infrastructure.Factories;

public class B2BProviderFactory : IB2BProviderFactory
{
    public IB2BProvider GetProvider(EB2BTypes b2bType)
    {
        return b2bType switch
        {
            EB2BTypes.Bovada => new BovadaProvider(),
            EB2BTypes.MGM => new MgmProvider(),
            _ => throw new ArgumentException("Invalid B2B Type")
        };
    }
}