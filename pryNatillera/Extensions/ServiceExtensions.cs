namespace pryNatillera.Extensions
{
    using LoggerService;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// clase que permite inyectar el servicio de registrar log
    /// </summary>
    public static class ServiceExtensions
    {
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            //singleton, creara un servicio cada vez que se necesite y luego cada solicitud posterior estara llamada la misma instancia.
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
    }
}
