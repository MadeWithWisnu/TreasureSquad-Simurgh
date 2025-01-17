using TreasureAPI.ApplicationDescriptions;
using TreasureAPI.ApplicationTypes;

namespace TreasureAPI.Configurations;

public static class ConfigureBussinessService
{
    public static IServiceCollection AddBussinessServices(this IServiceCollection services)
    {
        services.AddScoped<IApplicationDescriptionRepository, ApplicationDescriptionRepository>();
        services.AddScoped<IApplicationTypeRepository, ApplicationTypeRepository>();

        services.AddScoped<ApplicationDescriptionService>();
        services.AddScoped<ApplicationTypeService>();

        return services;
    }
}
