using ConsumoAPI_Dolar.Dtos;
using ConsumoAPI_Dolar.Models;

namespace ConsumoAPI_Dolar.Interfaces
{
    public interface IMoedasService
    {
        Task<ResponseGenerico<MoedasModel>> BuscarMoeda(string code);
    }
}