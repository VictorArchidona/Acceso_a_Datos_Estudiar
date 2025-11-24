using System.Net.Http;
using System.Threading.Tasks;

public class IAService
{
    private readonly HttpClient _httpClient;

    public IAService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // Método para preguntar a la "IA" usando la API local
    public async Task<string> PreguntarAsync(string mensaje)
    {
        // Llamada a tu API local (sin key)
        var response = await _httpClient.GetAsync("https://localhost:7160/api/paises");
        response.EnsureSuccessStatusCode();

        var apiData = await response.Content.ReadAsStringAsync();

        // Combinar la pregunta con los datos de la API
        var resultado = $"Simulación IA: Respondí a '{mensaje}' usando info: {apiData}";
        return resultado;
    }
}
