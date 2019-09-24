namespace NatilleraApiBusinnes.Models
{
    /// <summary>
    /// clase de negocio, la cual puede tener mas propiedades o menos que las clase de entity que serian
    /// iguales a las estructuras de la base de datos.
    /// </summary>
    public class Natillera
    {       
        public int IdNatillera { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
    }
}
