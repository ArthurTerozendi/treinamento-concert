using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VeiculosAPI2.DAO;
using VeiculosAPI2.Entities;

namespace VeiculosAPI2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotoController : ControllerBase
    {
        MotoDAO motoDAO;
        public MotoController()
        {
           motoDAO = new MotoDAO();
        }
        [HttpGet("{id}")]
        public ActionResult<Moto> GetOne(long id)
        {
            try
            {   
                var moto = motoDAO.GetMoto(id);
                return Ok(moto);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

       [HttpPost("{id}")]
        public ActionResult<Moto> Post()
        {
            try
            {
                var moto = motoDAO.AddMoto(new Moto(){
                    marca = "biz",
                    modelo = "bizinha",
                    cor = "preta",     
                    placa = "abc123",
                    numeroQuedas = 2,
                    CapotesDoGustavao = 2
                });
                return Ok(moto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    /*
        [HttpPut("{id}")]
        public ActionResult<Moto> Put()
        {

        }
        
        [HttpDelete("{id}")]
        public ActionResult<Moto> Delete()
        {

        }
    */
    }
}