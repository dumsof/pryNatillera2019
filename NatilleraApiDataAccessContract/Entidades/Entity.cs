namespace NatilleraApiDataAccessContract.Entidades
{
    using System.ComponentModel.DataAnnotations;

    public class Entity
    {
        /// <summary>
        /// controlar la concurrencia.
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
