namespace NatilleraApiDataAccess.Repositories
{
    using NatilleraApiDataAccessContract.IRepositories;


    /// <summary>
    /// patron repositorio, se aplica un contenedor o una sola area de trabajo, con el fin de poder inyectar todos los elementos 
    /// en una sola transacción cuando se llama al metodo Save.
    /// </summary>
    public class RepositorioContenedor : IRepositorioContenedor
    {
        private readonly NatilleraDBContext context;

        private INatilleraRepositorio natillera;

        public RepositorioContenedor(NatilleraDBContext context)
        {
            this.context = context;
        }

        public INatilleraRepositorio Natillera
        {
            get
            {
                if (this.natillera == null)
                {
                    this.natillera = new NatilleraRepositorio(this.context);
                }

                return this.natillera;
            }
        }

        public void Save()
        {
            this.context.SaveChanges();
        }
    }
}
