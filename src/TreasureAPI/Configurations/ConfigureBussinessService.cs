using TreasureAPI.ApplicationDescriptions;

namespace TreasureAPI.Configurations;

public static class ConfigureBussinessService
{
    public static IServiceCollection AddBussinessServices(this IServiceCollection services)
    {
        services.AddScoped<IApplicationDescriptionRepository, ApplicationDescriptionRepository>();
        services.AddScoped<ApplicationDescriptionService>();

        return services;
    }
}
