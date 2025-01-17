using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using TreasureAPI.Configurations;
using TreasureDataAccess;

namespace TreasureAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        var builder = WebApplication.CreateBuilder(args);
        IServiceCollection services = builder.Services;
        ConfigurationManager configuration = builder.Configuration;
        Dependencies.ConfigureService(configuration, services);
        services.AddControllers();
        services.AddBussinessServices();
        services.AddSwaggerGen(options => {
            options.SwaggerDoc("v1", new OpenApiInfo(){Title ="Simurgh API"});
            options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme{
                Description = "Enter the token with the `Bearer: ` prefix, e.g. 'Bearer abcde12345'",
                In = ParameterLocation.Header,
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
            });
            options.OperationFilter<SecurityRequirementsOperationFilter>();
        });
        services.AddCors(options =>
        {
            options.AddPolicy(name: MyAllowSpecificOrigins,
                            policy  =>
                            {
                                policy.WithOrigins("http://localhost:5173").AllowAnyHeader().AllowAnyMethod();
                            });
        });
        var app = builder.Build();
        app.UseRouting();
        app.MapControllers();
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseCors(MyAllowSpecificOrigins);
        app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}
