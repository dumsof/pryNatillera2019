using System;
using System.Collections.Generic;
using System.Text;

namespace NatilleraApiDataAccessContract.IRepositories
{
    public interface IRepositorioContenedor
    {
        INatilleraRepositorio Natillera { get; }
        void Save();
    }
}
