using ConsumoAPI_Dolar.Dtos;

namespace ConsumoAPI_Dolar.Interfaces
{
    public interface IMoedasService
    {
        Task<ResponseGenerico<MoedasResponse>> BuscarMoeda(string code);
    }
}