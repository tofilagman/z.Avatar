using Microsoft.Extensions.DependencyInjection;

namespace z.Avatar
{
    public static class ServiceInjector
    {
        public static void AddAvatar(this IServiceCollection services)
        { 
            services.AddSingleton<IAvatarService, AvatarService>();
        }
    }
}
