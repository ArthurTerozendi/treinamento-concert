using Commons_Core.DAO;
using Commons_Core.DAO.Interfaces;
using PessoasAPI.Entities;
using PessoasAPI.VO;

namespace PessoasAPI.DAO
{
    public interface IPessoaDAO : IBaseDao<PessoaContext, PessoaVO, Pessoa, DefaultMapper>
    {

    }
}