namespace NatilleraApiAplication.Services
{
    using NatilleraApiAplicationContract.IServices;
    using NatilleraApiDataAccessContract.IRepositories;

    public class NatilleraServices : INatilleraServices
    {
        private readonly IRepositorioContenedor repositorio;
        public NatilleraServices(IRepositorioContenedor repositorio)
        {
            this.repositorio = repositorio;
        }

        public void GuardarEjemplo()
        {
            //this.repositorio.Natillera.Create(EntidadNatillera);
            this.repositorio.Save();
        }

    }
}
