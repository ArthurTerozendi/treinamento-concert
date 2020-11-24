using System;
using System.Linq;
using VeiculosAPI.Entities;

namespace VeiculosAPI.DAO
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