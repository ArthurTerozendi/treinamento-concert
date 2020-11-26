using System;
using System.Collections.Generic;
using System.Linq;
using VeiculosAPI2.Entities;


namespace VeiculosAPI2.DAO
{
    public interface IMotoDAO
    {
        Moto GetMoto(long id);
        Moto AddMoto(Moto moto);
        Moto UpadateMoto(Moto moto, long id);
        List<Moto> AddAllMotos(List<Moto> motos);
        Moto DeleteMoto(long id);
        List<Moto> GetAllMotos();
    }
}