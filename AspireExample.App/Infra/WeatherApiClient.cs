using AspireExample.App.Models;

namespace AspireExample.App.Infra;

public class WeatherApiClient
{
    private readonly HttpClient _client;

    public WeatherApiClient(HttpClient client)
    {
        _client = client;
    }

    public async Task<WeatherForecast[]> GetWeather()
    {
        return (await _client.GetFromJsonAsync<WeatherForecast[]>("weatherforecast"))!;
    }
}
