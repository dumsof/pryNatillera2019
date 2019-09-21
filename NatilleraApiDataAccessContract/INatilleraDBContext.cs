namespace NatilleraApiDataAccessContract
{
    using Microsoft.EntityFrameworkCore;
    using NatilleraApiDataAccessContract.Entidades;
   

    public interface INatilleraDBContext
    {
        DbSet<NatilleraEntity> Natillera { get; set; }
    }
}
