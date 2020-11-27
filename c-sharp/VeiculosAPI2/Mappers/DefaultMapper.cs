using AutoMapper;
using VeiculosAPI2.VO;

namespace VeiculosAPI2.Entities
{
    public class DefaultMapper : Profile
    {
        public DefaultMapper(){
            CreateMap<Carro, CarroVO>()
            .ReverseMap()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<Caminhao, CaminhaoVO>()
            .ReverseMap()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<Moto, MotoVO>()
            .ReverseMap()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}