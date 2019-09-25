namespace pryNatillera
{   
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using NatilleraApiDataAccess;
    using NLog;
    using NotificacionApiCrossClothing.Register;
    using pryNatillera.Extensions;
    using Swashbuckle.AspNetCore.Swagger;
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            //se utiliza nlog para crear un archivo de log, Install-Package NLog -Version 4.6.7.
            //linea que permite optener la configuracion para nlog, por ejemplo ruta archivo nombre archivo.
            LogManager.LoadConfiguration(String.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Dum: se agrega la inyeccion para el logger
            //services.AddSingleton<ILoggerManager, LoggerManager>();
            services.ConfigureLoggerService();

            //Dum: se realiza una clase que contiene la configuración y se inyecta la configuración para base de datos.
            services.ConfiguracionSqlContext(Configuration);
            //services.AddDbContext<NatilleraDBContext>(opcion => opcion.UseSqlServer(Configuration.GetConnectionString("DefaultConection")));

            //Dum: manejo del token.
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<NatilleraDBContext>()
                .AddDefaultTokenProviders();

            //Dum: se inyecta el contenedor del repositorio
            //services.ConfiguracionRepositoryContenedor();

            //Dum: se injectan los servicios de las capas de repositorio y servicios.
            ServiceExtensions.AddResgistro(services);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //DUM: Inicio configuración swagger, Install-Package Swashbuckle.AspNetCore
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Swagger Api Natillera",
                    Description = "Servicio para la administración de la información de natilleras",
                    TermsOfService = "No Aplica",
                    Contact = new Contact() { Name = "Talking Dotnet", Email = "contact@talkingdotnet.com", Url = "www.talkingdotnet.com" }
                });
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.DocInclusionPredicate((docName, description) => true);
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                c.IncludeXmlComments(xmlPath);
            });
            //DUM: Final Configuración Swagger
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            //DUM: configuaracion Swager
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Web Api Natillera");
            });
            //DUM: Final Configuracion Swagger

            //Dum: se realiza el llamado del middleware del manejo de exception global.
            app.ConfigureCustomExceptionMiddleware();

            app.UseMvc();
        }
    }
}
