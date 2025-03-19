namespace BM.B2BProvider.Presentation.Extensions;

public static class IoCExtensions
{
    public static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services)
    {
        services.AddMediatR(config => config.RegisterServicesFromAssembly(Application.AssemblyReference.Assembly));

        return services;
    }
}