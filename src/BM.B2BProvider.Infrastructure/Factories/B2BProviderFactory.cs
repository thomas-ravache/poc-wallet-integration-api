using BM.B2BProvider.Domain;
using BM.B2BProvider.Domain.Enums;
using BM.B2BProvider.Infrastructure.Providers;

namespace BM.B2BProvider.Infrastructure.Factories;

public static class B2BProviderFactory
{
    public static IB2BProvider GetProvider(EB2BTypes b2bType)
    {
        return b2bType switch
        {
            EB2BTypes.Bovada => new BovadaProvider(),
            EB2BTypes.MGM => new MgmProvider(),
            _ => throw new ArgumentException("Invalid B2B Type")
        };
    }
}