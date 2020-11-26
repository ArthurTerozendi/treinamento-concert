using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Commons_Core.API;
using PessoasAPI.DAO;
using PessoasAPI.Entities;
using PessoasAPI.Business;
using PessoasAPI.Business.Interface;
using PessoasAPI.VO;

namespace PessoasAPI.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : BaseRoutes<IPessoaBusiness, IPessoaDAO, PessoaContext, PessoaVO, Pessoa, DefaultMapper>
    {
        public PessoaController(IPessoaBusiness pessoaBusiness)
            :base(pessoaBusiness)
        {

        }
    }
}