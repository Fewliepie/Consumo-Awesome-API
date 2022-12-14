using AutoMapper;
using ConsumoAPI_Dolar.Dtos;
using ConsumoAPI_Dolar.Interfaces;
using ConsumoAPI_Dolar.Models;

namespace ConsumoAPI_Dolar.Services
{
    public class MoedasService : IMoedasService
    {
        private readonly IMapper _mapper;
        private readonly IAwesomeApi _awesomeApi;

        public MoedasService(IMapper mapper, IAwesomeApi awesomeApi)
        {
            _mapper = mapper;
            _awesomeApi = awesomeApi;
        }

        public async Task<ResponseGenerico<MoedasModel>> BuscarMoeda(string code)
        {
            var moeda = await _awesomeApi.BuscarMoedaPorCodigo(code);
            //return _mapper.Map<ResponseGenerico<MoedasResponse>>(moeda);
            return moeda;
        }
    }
}