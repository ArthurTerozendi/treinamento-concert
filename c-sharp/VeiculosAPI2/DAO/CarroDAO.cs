using Commons_Core.DAO;
using VeiculosAPI2.VO;
using VeiculosAPI2.Entities;

namespace VeiculosAPI2.DAO
{
    public class CarroDAO : BaseDao<VeiculosContext, CarroVO, Carro, DefaultMapper>, ICarroDAO
    {

    }
}