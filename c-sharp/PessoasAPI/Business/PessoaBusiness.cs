using Commons_Core.Business;
using PessoasAPI.DAO;
using PessoasAPI.Entities;
using PessoasAPI.VO;
using PessoasAPI.Business.Interface;

namespace PessoasAPI.Business
{
    public class PessoaBusiness : BaseBusiness<IPessoaDAO, PessoaContext, PessoaVO, Pessoa, DefaultMapper>, IPessoaBusiness
    {
        public PessoaBusiness(IPessoaDAO dao)
            :base(dao)
        {

        }
    }
}