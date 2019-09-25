using System.ComponentModel.DataAnnotations;

namespace NatilleraApiBusinnes.Models
{
    /// <summary>
    /// clase de negocio, la cual puede tener mas propiedades o menos que las clase de entity que serian
    /// iguales a las estructuras de la base de datos.
    /// </summary>
    public class Natillera
    {       
        public int IdNatillera { get; set; }

        [Required(ErrorMessage = "El campos {0} es requerido, por favor verifique.")]
        [StringLength(50, ErrorMessage = "El Nombre debe contener menos de 50 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campos {0} es requerido, por favor verifique.")]
        [StringLength(150, ErrorMessage = "La Descripción debe contener menos de 150 caracteres.")]
        public string Descripcion { get; set; }
    }
}
