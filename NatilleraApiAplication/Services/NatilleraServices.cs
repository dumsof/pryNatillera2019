namespace NatilleraApiAplication.Services
{
    using NatilleraApiAplicationContract.IServices;
    using NatilleraApiAplicationContract.Models;
    using NatilleraApiBusinnes.Models;
    using NatilleraApiDataAccess.AutoMapper;
    using NatilleraApiDataAccessContract.IRepositories;
    using NotificacionApiCrossClothing.Message;

    public class NatilleraServices : INatilleraServices
    {
        private readonly IRepositorioContenedor repositorio;
        public NatilleraServices(IRepositorioContenedor repositorio)
        {
            this.repositorio = repositorio;
        }

        public Respuesta GuardarNatillera(Natillera natillera)
        {
            Message message = new Message(MessageCode.Message0000);

            this.repositorio.Natillera.Create((NatilleraApiDataAccessContract.Entidades.Natilleras)NatilleraMapper.NatilleraEntityMap((Natillera)natillera));
            this.repositorio.Save();

            return new Respuesta
            {
                Mensaje = new Mensaje
                {
                    Identificador = message.Code,
                    Titulo = message.Title,
                    Contenido = message.Text
                }
            };
        }
    }
}
