using Microsoft.Extensions.DependencyInjection;
using Template.Application.Services.User;

namespace Template.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAddUserService, AddUserService>();
        
        return services;
    }
}