using BM.B2BProvider.Application.Interfaces.Factories;
using BM.B2BProvider.Infrastructure.Factories;

namespace BM.B2BProvider.Presentation.Extensions;

public static class IoCExtensions
{
    public static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services)
    {
        services.AddMediatR(config => config.RegisterServicesFromAssembly(Application.AssemblyReference.Assembly));
        services.AddSingleton<IB2BProviderFactory, B2BProviderFactory>();

        return services;
    }
}