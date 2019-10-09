namespace NatilleraApiDataAccessContract.Entidades
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Entity
    {
        /// <summary>
        /// controlar la concurrencia.
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; }

        /// <summary>
        /// Decorado que permite generar la fecha cada vez que se crea un registro.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime FechaCreacion { get; set; }

        /// <summary>
        /// Decorado que permite generar la fecha cada vez que se actualiza un registro.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime FechaActualizacion { get; set; }
    }
}
