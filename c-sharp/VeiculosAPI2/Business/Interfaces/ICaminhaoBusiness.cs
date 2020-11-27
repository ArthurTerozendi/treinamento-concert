using Commons_Core.Business.Interfaces;
using VeiculosAPI2.DAO;
using VeiculosAPI2.VO;
using VeiculosAPI2.Entities;

namespace VeiculosAPI2.Business
{
    public interface ICaminhaoBusiness : IBaseBusiness<ICaminhaoDAO, VeiculosContext, CaminhaoVO, Caminhao, DefaultMapper>
    {

    }
}