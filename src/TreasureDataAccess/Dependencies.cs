using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TreasureDataAccess.Models;

namespace TreasureDataAccess;

public class Dependencies
{
    public static void ConfigureService(IConfiguration configuration, IServiceCollection services)
    {
        services.AddDbContext<SimurghContext>(
            option => option.UseSqlServer(configuration.GetConnectionString("SimurghConnection"))
        );
    }
}
