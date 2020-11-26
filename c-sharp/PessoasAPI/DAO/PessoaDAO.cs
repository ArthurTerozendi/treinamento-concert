using System.Linq;
using Commons_Core.DAO;
using PessoasAPI.Entities;
using PessoasAPI.VO;

namespace PessoasAPI.DAO
{
    public class PessoaDAO : BaseDao<PessoaContext, PessoaVO, Pessoa, DefaultMapper>, IPessoaDAO
    {
        public override IQueryable<Pessoa> GetCustomWhere(IQueryable<Pessoa> listToFilter, PessoaVO filter)
        {
            return listToFilter;
        }
    }
}