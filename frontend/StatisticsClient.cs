using System.Text.Json;

namespace frontend;

public class StatisticsClient
{
    private readonly HttpClient _client;

    public StatisticsClient(HttpClient client)
    {
        _client = client;
    }

    public async Task<IEnumerable<Statistics>?> Get()
    {
        var httpResponse = await _client.GetAsync($"Statistics");

        var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        httpResponse.EnsureSuccessStatusCode();

        var body = await httpResponse.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<IEnumerable<Statistics>>(body, options);
    }
}
