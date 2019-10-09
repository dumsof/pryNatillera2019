namespace NatilleraApiDataAccessContract.Entidades
{   
    using System.ComponentModel.DataAnnotations;  

    //clase para mapear los campos de la base de datos.
    public class NatilleraEntity: Entity
    {
        [Key]
        public int IdNatillera { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }        
    }
}
