using Commons_Core.Business;
using VeiculosAPI2.DAO;
using VeiculosAPI2.VO;
using VeiculosAPI2.Entities;

namespace VeiculosAPI2.Business
{
    public class CaminhaoBusiness : BaseBusiness<ICaminhaoDAO, VeiculosContext, CaminhaoVO, Caminhao, DefaultMapper>, ICaminhaoBusiness
    {
        public CaminhaoBusiness(ICaminhaoDAO dao)
            :base(dao)
        {

        }
    }
}