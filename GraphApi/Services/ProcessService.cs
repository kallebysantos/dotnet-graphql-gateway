using GraphApi.Types;

namespace GraphApi.Services;

public interface IProcessService
{
    Task<IEnumerable<Process>> GetProcessAsync();
}

public class ProcessService : IProcessService
{
    private readonly HttpClient _httpClient;

    public ProcessService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<IEnumerable<Process>> GetProcessAsync() =>
        await _httpClient.GetFromJsonAsync<IEnumerable<Process>>("http://localhost:5077")
        ?? Enumerable.Empty<Process>();
}
