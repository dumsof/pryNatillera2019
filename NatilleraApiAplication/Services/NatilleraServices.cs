namespace NatilleraApiAplication.Services
{
    using NatilleraApiAplicationContract.IServices;
    using NatilleraApiBusinnes.Models;
    using NatilleraApiDataAccess.AutoMapper;
    using NatilleraApiDataAccessContract.IRepositories;

    public class NatilleraServices : INatilleraServices
    {
        private readonly IRepositorioContenedor repositorio;
        public NatilleraServices(IRepositorioContenedor repositorio)
        {
            this.repositorio = repositorio;
        }

        public void GuardarNatillera(Natillera natillera)
        {
            this.repositorio.Natillera.Create(NatilleraMapper.NatilleraEntityMap(natillera));
            this.repositorio.Save();
        }

    }
}
