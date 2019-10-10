﻿namespace NatilleraApiDataAccessContract
{
    using Microsoft.EntityFrameworkCore;
    using NatilleraApiDataAccessContract.Entidades;


    public interface INatilleraDBContext
    {
        DbSet<Natilleras> Natilleras { get; set; }
        DbSet<TiposDocumentos> TiposDocumentos { get; set; }
        DbSet<Prestamos> Prestamos { get; set; }
        DbSet<ActividadesRecaudos> ActividadesRecaudos { get; set; }
        DbSet<Socios> Socios { get; set; }
        DbSet<NatilleraSocios> NatilleraSocios { get; set; }
        DbSet<CuotasPrestamos> CuotasPrestamos { get; set; }
        DbSet<CuotasSocios> CuotasSocios { get; set; }
    }
}
