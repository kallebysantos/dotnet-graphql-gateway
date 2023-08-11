namespace GraphApi.Types;

public class Document
{
    public required Guid Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
}

public class DocumentType : ObjectType<Document>
{
    protected override void Configure(IObjectTypeDescriptor<Document> descriptor)
    {
        descriptor.Field(d => d.Description).Ignore();

        base.Configure(descriptor);
    }
}
