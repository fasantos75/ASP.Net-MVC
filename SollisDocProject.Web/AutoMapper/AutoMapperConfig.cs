
using AutoMapper;
using SollisDocProject.Domain.Entities;

namespace SollisDocProject.Web.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<CadCplxAnaViewModel, CadCplxAna>()
                     .ForMember(c => c.SelectedIdCplxAna, c => c.Ignore())
                     .ReverseMap();
                x.CreateMap<CadCplxAnaViewModel, CadCplxAna>().ReverseMap();
            });
        }

    }
}