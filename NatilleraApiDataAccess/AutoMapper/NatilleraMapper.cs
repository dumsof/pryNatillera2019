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
        public static Natilleras NatilleraEntityMap(NatilleraApiBusinnes.Models.Natillera natillera)
        {
            return new NatilleraApiDataAccessContract.Entidades.Natilleras
            {
                NatilleraId = natillera.NatilleraId,
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
        public static Natillera NatilleraMap(NatilleraApiDataAccessContract.Entidades.Natilleras natilleraEntity)
        {
            return new Natillera
            {
                NatilleraId = natilleraEntity.NatilleraId,
                Nombre = natilleraEntity.Nombre,
                Descripcion = natilleraEntity.Descripcion
            };
        }
    }
}
