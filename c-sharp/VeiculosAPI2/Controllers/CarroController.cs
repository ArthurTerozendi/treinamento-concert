using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Commons_Core.API;
using VeiculosAPI2.DAO;
using VeiculosAPI2.Entities;
using VeiculosAPI2.Business;
using VeiculosAPI2.Business;
using VeiculosAPI2.VO;

namespace VeiculosAPI2.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : BaseRoutes<ICarroBusiness, ICarroDAO, VeiculosContext, CarroVO, Carro, DefaultMapper>
    {
        public CarroController(ICarroBusiness carroBusiness)
            :base(carroBusiness)
        {

        }
    }
}