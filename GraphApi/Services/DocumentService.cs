using GraphApi.Types;

namespace GraphApi.Services;

public interface IDocumentService
{
    Task<Document?> GetDocumentAsync(string documentId);
}

public class DocumentService : IDocumentService
{
    private readonly HttpClient _httpClient;

    public DocumentService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<Document?> GetDocumentAsync(string documentId) =>
        await _httpClient.GetFromJsonAsync<Document>($"http://localhost:5062/{documentId}");
}
