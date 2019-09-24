namespace pryNatillera.Extensions
{
    using LoggerService;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using NatilleraApiDataAccess;
    using NatilleraApiDataAccess.Repositories;
    using NatilleraApiDataAccessContract.IRepositories;

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

        public static void ConfiguracionSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NatilleraDBContext>(opcion => 
            opcion.UseSqlServer(configuration.GetValue<string>("ConnectionString:DataBaseConexion")));
        }
    }
}
