using System;
using System.Collections.Generic;
using System.Linq;
using VeiculosAPI2.Entities;


namespace VeiculosAPI2.DAO
{
    public interface IMatoDAO
    {
        Moto GetMoto(long id);
        Moto AddMoto(Moto moto);
        Moto UpadateMoto(Moto moto, long id);
        Moto AddAllMotos(List<Moto> motos);
        Moto DeleteMoto(long id);
    }
}