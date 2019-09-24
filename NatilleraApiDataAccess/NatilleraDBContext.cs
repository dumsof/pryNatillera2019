namespace NatilleraApiDataAccess
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using NatilleraApiDataAccessContract;
    using NatilleraApiDataAccessContract.Entidades;

    public class NatilleraDBContext : IdentityDbContext<ApplicationUser>, INatilleraDBContext
    {

        //cuando se hereda de IdentityDbContext<ApplicationUser>, se crean las tablas para 
        //el manejo de usuarios.
        /// <summary>
        /// Initializes a new instance of the <see cref="AplicationDbContext"/> class.
        /// </summary>
        /// <param name="opcion">The opcion<see cref="DbContextOptions{AplicationDbContext}"/></param>
        public NatilleraDBContext(DbContextOptions<NatilleraDBContext> opcion) : base(opcion)
        {
        }

        public DbSet<NatilleraEntity> Natilleras { get; set; }

        /// <summary>
        /// Gets or sets the Paises
        /// </summary>
        //public DbSet<Pais> Paises { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
