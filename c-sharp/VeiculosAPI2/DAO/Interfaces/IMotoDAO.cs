using Commons_Core.DAO.Interfaces;
using VeiculosAPI2.VO;
using VeiculosAPI2.Entities;

namespace VeiculosAPI2.DAO
{
    public interface IMotoDAO : IBaseDao<VeiculosContext, MotoVO, Moto, DefaultMapper>
    {
        
    }
}