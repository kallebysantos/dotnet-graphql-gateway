using GraphApi.Services;
using GraphApi.Types;

namespace GraphApi;

public class Query
{
    public async Task<IEnumerable<Process>> GetProcesses(
        [Service] IProcessService processService
    ) => await processService.GetProcessAsync();

    public async Task<Document?> GetDocument(
        [Service] IDocumentService documentService,
        string id
    ) => await documentService.GetDocumentAsync(id);
}
