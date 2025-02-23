using Microsoft.Extensions.DependencyInjection;
using VRCZ.Core.Services;

namespace VRCZ.Core.Extensions;

public static class ServiceCollectionExtenstion
{
    public static IServiceCollection AddVRCZCore(this IServiceCollection services)
    {
        services.AddKiotaHandlers();

        services.AddSingleton<VRChatAuthService>();
        services.AddSingleton<UserProfileService>();

        services.AddTransient(serviceProvider =>
            serviceProvider.GetRequiredService<VRChatApiClientFactory>().GetClient());
        services.AddHttpClient<VRChatApiClientFactory>()
            .ConfigurePrimaryHttpMessageHandler(servicesProvider => new SocketsHttpHandler
            {
                CookieContainer = servicesProvider.GetRequiredService<UserProfileService>().CookieContainer,
                UseCookies = true,
                PooledConnectionLifetime = TimeSpan.FromMinutes(2)
            })
            .AttachKiotaHandlers();

        return services;
    }
}
