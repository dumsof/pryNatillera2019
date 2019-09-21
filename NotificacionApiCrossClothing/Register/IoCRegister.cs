namespace NotificacionApiCrossClothing.Register
{
    using Microsoft.Extensions.DependencyInjection;
    using NatilleraApiAplication.Services;
    using NatilleraApiAplicationContract.IServices;

    public static class IoCRegister
    {

        public static IServiceCollection AddResgistro(this IServiceCollection services)
        {
            AddResgistroServices(services);
            AddResgistroRepositorio(services);
            return services;
        }

        private static IServiceCollection AddResgistroServices(this IServiceCollection services)
        {
            services.AddTransient<INatilleraServices, NatilleraServices>();
            return services;
        }

        private static IServiceCollection AddResgistroRepositorio(this IServiceCollection services)
        {
            //services.AddTransient<INatilleraRepositorio, NatilleraRepositorio>();
            return services;
        }

    }
}
