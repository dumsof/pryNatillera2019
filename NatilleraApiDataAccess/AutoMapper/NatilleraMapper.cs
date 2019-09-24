namespace NatilleraApiDataAccess.AutoMapper
{
    using NatilleraApiBusinnes.Models;
    using NatilleraApiDataAccessContract.Entidades;

    public static class NatilleraMapper
    {
        /// <summary>
        /// se tranforma la informacion del negocio a la entidad que necesita la capa de repositorio
        /// </summary>
        /// <param name="natillera"></param>
        /// <returns></returns>
        public static NatilleraEntity NatilleraEntityMap(Natillera natillera)
        {
            return new NatilleraEntity
            {
                IdNatillera = natillera.IdNatillera,
                Nombre = natillera.Nombre,
                Descripcion = natillera.Descripcion
            };
        }

        /// <summary>
        /// se transforma la informacion que envia la capa de repositorio a la entidad
        /// que necesita la capa de negocio que esta en el modelo del Bisness
        /// </summary>
        /// <param name="natilleraEntity"></param>
        /// <returns></returns>
        public static Natillera NatilleraMap(NatilleraEntity natilleraEntity)
        {
            return new Natillera
            {
                IdNatillera = natilleraEntity.IdNatillera,
                Nombre = natilleraEntity.Nombre,
                Descripcion = natilleraEntity.Descripcion
            };
        }
    }
}
