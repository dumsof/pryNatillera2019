namespace NatilleraApiDataAccessContract
{
    using Microsoft.EntityFrameworkCore;
    using NatilleraApiDataAccessContract.Entidades;
   

    public interface INatilleraDBContext
    {
        DbSet<Natilleras> Natilleras { get; set; }
    }
}
