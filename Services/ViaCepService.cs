

using Newtonsoft.Json; // Certifique-se de ter o Newtonsoft.Json instalado
using Pizzaria2._0.Models;


public class ViaCepService
{
    private readonly HttpClient _httpClient;

    public ViaCepService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // Função assíncrona que comunica com o servidor da ViaCep
    public async Task<Address> GetAdressByCep(string cep)
    {
        // Verifica se o CEP é nulo ou vazio
        if (string.IsNullOrWhiteSpace(cep))
        {
            return null; // Retorna nulo se o CEP não for válido
        }

        // Executando a requisição para a rota da ViaCep
        var retornoRequisicao = await _httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/");

        // Verificando se a requisição respondeu com sucesso (status code 200)
        if (retornoRequisicao.IsSuccessStatusCode)
        {
            // Obtém a informação retornada pela API
            var objetoSerializado = await retornoRequisicao.Content.ReadAsStringAsync();
            // Desserializa o objeto serializado, recuperado do retorno da requisição da ViaCep
            return JsonConvert.DeserializeObject<Address>(objetoSerializado);
        }

        return null; // Retorna nulo se a requisição não for bem-sucedida
    }
}