using AutoMapper;
using ConsumoAPI_Dolar.Dtos;
using ConsumoAPI_Dolar.Models;

namespace ConsumoAPI_Dolar.Mappings
{
    public class MoedasMapping : Profile
    {
        public MoedasMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<MoedasResponse, MoedasModel>();
            CreateMap<MoedasModel, MoedasResponse>();
        }
    }
}