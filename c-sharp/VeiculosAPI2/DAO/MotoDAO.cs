using System;
using System.Linq;
using VeiculosAPI2.Entities;
using System.Collections.Generic;

namespace VeiculosAPI2.DAO
{
    public class MotoDAO : IMatoDAO
    {
        public Moto GetMoto(long id)
        {
            try
            {
                using(VeiculosContext ctx =  new VeiculosContext())
                {
                    var query = ctx.Moto.Where(m => m.id == id);
                    return query.First();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Moto AddMoto(Moto moto)
        {
            try
            {
                using(VeiculosContext ctx = new VeiculosContext())
                {
                    var createdMoto = ctx.Moto.Add(moto);
                    ctx.SaveChanges();
                    return createdMoto.Entity;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Moto UpadateMoto(Moto moto, long id)
        {
            try
            {
                using(VeiculosContext ctx = new VeiculosContext())
                {
                    var motoToUpadate = ctx.Moto.Where(m => m.id == id).First();

                    motoToUpadate.marca = moto.marca;
                    motoToUpadate.modelo = moto.modelo;
                    motoToUpadate.cor = moto.cor;
                    motoToUpadate.placa = moto.placa;
                    motoToUpadate.numeroQuedas = moto.numeroQuedas;
                    //motoToUpadate.capotesDoGustavo = moto.capotesDoGustavo;
                    
                    ctx.SaveChanges();
                    return motoToUpadate;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Moto> AddAllMotos(List<Moto> motos)
        {
            try
            {
                using(VeiculosContext ctx = new VeiculosContext())
                {
                    foreach (var moto in moto)
                    {
                        var createdMoto = ctx.Moto.Add(moto);
                    }
                    ctx.SaveChanges();
                   
                }
                 return motos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Moto DeleteMoto(long id)
        {
            return null;
        }

    }
}