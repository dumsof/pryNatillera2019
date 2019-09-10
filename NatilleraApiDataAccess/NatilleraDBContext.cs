namespace NatilleraApiDataAccess
{
    using Microsoft.EntityFrameworkCore;
    using NatilleraApiDataAccessContract;


    public class NatilleraDBContext : DbContext, INatilleraDBContext
    {
        public NatilleraDBContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
