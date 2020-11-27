using Commons_Core.Business;
using VeiculosAPI2.DAO;
using VeiculosAPI2.VO;
using VeiculosAPI2.Entities;

namespace VeiculosAPI2.Business
{
    public class CarroBusiness : BaseBusiness<ICarroDAO, VeiculosContext, CarroVO, Carro, DefaultMapper>, ICarroBusiness
    {
        public CarroBusiness(ICarroDAO dao)
            :base(dao)
        {

        }
    }
}