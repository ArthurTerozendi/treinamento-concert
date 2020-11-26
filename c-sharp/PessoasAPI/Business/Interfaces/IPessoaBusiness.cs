using Commons_Core.Business.Interfaces;
using PessoasAPI.DAO;
using PessoasAPI.Entities;
using PessoasAPI.VO;

namespace PessoasAPI.Business.Interface
{
    public interface IPessoaBusiness : IBaseBusiness<IPessoaDAO, PessoaContext, PessoaVO, Pessoa, DefaultMapper>
    {
        
    }
}