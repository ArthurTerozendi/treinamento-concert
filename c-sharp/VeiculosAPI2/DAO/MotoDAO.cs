using System;
using System.Linq;
using VeiculosAPI2.Entities;

namespace VeiculosAPI2.DAO
{
    public class MotoDAO
    {
        public static Moto GetMotos(int id)
        {
            try
            {
                VeiculosContext ctx =  new VeiculosContext();
                var query = ctx.Moto.Where(m => m.id == id);
                return query.First();
            }
            catch (Exception ex)
            {
                throw;
            }
        } 
    }
}