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
        private List<Moto> motos = new List<Moto>();

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

        [HttpGet]
        public ActionResult<Moto> GetAllMotos()
        {
            try
            {
                motos = motoDAO.GetAllMotos();
                return Ok(motos);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
       [HttpPost]
        public ActionResult<Moto> Post(Moto moto)
        {
            try
            {
                var mt = motoDAO.AddMoto(moto);
                return Ok(mt);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    
        [HttpPut("{id}")]
        public ActionResult<Moto> Put(long id, Moto moto)
        {
            try
            {
                var mt = motoDAO.UpadateMoto(moto, id);
                return Ok(mt);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        
        [HttpDelete("{id}")]
        public ActionResult<Moto> Delete(long id)
        {
            try
            {
                var mt = motoDAO.DeleteMoto(id);
                return Ok(mt);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}