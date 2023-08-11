using GraphApi.Services;

namespace GraphApi.Types;

public class Process
{
    public required Guid Id { get; set; }
    public required IEnumerable<Guid> Documents { get; set; }
    public required string Author { get; set; }
    public required string Description { get; set; }
}

public class ProcessType : ObjectType<Process>
{
    protected override void Configure(IObjectTypeDescriptor<Process> descriptor)
    {
        descriptor.Field(p => p.Documents).Ignore();

        descriptor
            .Field("Documents")
            .Resolve(context =>
            {
                var documentService = context.Service<IDocumentService>();
                var currentProcess = context.Parent<Process>();

                var documentTasks = currentProcess.Documents.Select(
                    async documentId =>
                        await documentService.GetDocumentAsync(documentId.ToString())
                );

                return Task.WhenAll(documentTasks);
            });
    }
}
