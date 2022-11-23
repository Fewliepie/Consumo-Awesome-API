using System.Dynamic;
using System.Text.Json;
using ConsumoAPI_Dolar.Dtos;
using ConsumoAPI_Dolar.Interfaces;
using ConsumoAPI_Dolar.Models;

namespace ConsumoAPI_Dolar.Rest
{
    public class AwesomeApiRest : IAwesomeApi
    {
        public async Task<ResponseGenerico<MoedasModel>> BuscarMoedaPorCodigo(string code)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://economia.awesomeapi.com.br/json/last/{code}");

            var response = new ResponseGenerico<MoedasModel>();
            using (var client = new HttpClient()){
                var responseAwesomeApi = await client.SendAsync(request);
                var contentResp = await responseAwesomeApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<MoedasModel>(contentResp);

                if (responseAwesomeApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseAwesomeApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseAwesomeApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);

                }
            }
            return response;
        }
    }
}