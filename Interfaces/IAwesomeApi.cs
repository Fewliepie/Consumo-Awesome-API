using ConsumoAPI_Dolar.Dtos;
using ConsumoAPI_Dolar.Models;

namespace ConsumoAPI_Dolar.Interfaces
{
    public interface IAwesomeApi
    {
          Task<ResponseGenerico<MoedasModel>> BuscarMoedaPorCodigo(string code);
    }
}