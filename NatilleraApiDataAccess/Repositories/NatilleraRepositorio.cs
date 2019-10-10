namespace NatilleraApiDataAccess.Repositories
{
    using NatilleraApiDataAccessContract.Entidades;
    using NatilleraApiDataAccessContract.IRepositories;   

    public class NatilleraRepositorio: RepositoryBase<Natilleras>, INatilleraRepositorio
    {
        public NatilleraRepositorio(NatilleraDBContext repositorioContexto): base(repositorioContexto)
        {
        }
    }
}
