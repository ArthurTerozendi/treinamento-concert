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
        public MotoController()
        {
            MotoDAO motoDAO = new MotoDAO();
        }
        [HttpGet("{id}")]
        public ActionResult<Moto> GetOne(long id)
        {
            try
            {   
                var moto = motoDAO.GetMotos(id);
                return Ok(moto);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

       /* [HttpPost("{id}")]
        public ActionResult<Moto> Post()
        {

        }

        [HttpPut("{id}")]
        public ActionResult<Moto> Put()
        {

        }
        
        [HttpDelete("{id}")]
        public ActionResult<Moto> Delete()
        {

        }*/
    }
}