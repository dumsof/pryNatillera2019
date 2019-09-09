namespace NatilleraApiDataAccess
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class NatilleraDBContext : DbContext
    {
        public NatilleraDBContext()
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
