using AutoMapper;
using PessoasAPI.VO;

namespace PessoasAPI.Entities
{
    public class DefaultMapper : Profile
    {
        public DefaultMapper()
        {
            CreateMap<Pessoa, PessoaVO>()
                .ReverseMap()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}