namespace NatilleraApiAplication.Services
{
    using NatilleraApiAplicationContract.IServices;
    using NatilleraApiAplicationContract.Models;
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

        public Respuesta GuardarNatillera(Natillera natillera)
        {
            
            this.repositorio.Natillera.Create(NatilleraMapper.NatilleraEntityMap(natillera));
            this.repositorio.Save();

            return new Respuesta
            {
                Mensaje = new Mensaje
                {
                    Identificador = 1,
                    Titulo = "Registro Exitoso",
                    Contenido = "Información registrada con éxito"
                }
            };
        }
    }
}
