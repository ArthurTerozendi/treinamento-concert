using Commons_Core.Business;
using VeiculosAPI2.DAO;
using VeiculosAPI2.VO;
using VeiculosAPI2.Entities;

namespace VeiculosAPI2.Business
{
    public class MotoBusiness : BaseBusiness<IMotoDAO, VeiculosContext, MotoVO, Moto, DefaultMapper>, IMotoBusiness
    {
        public MotoBusiness(IMotoDAO dao)
            :base(dao)
        {

        }
    }
}