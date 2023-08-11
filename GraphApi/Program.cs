using GraphApi;
using GraphApi.Services;
using GraphApi.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddSingleton<IProcessService, ProcessService>()
    .AddSingleton<IDocumentService, DocumentService>();

builder.Services
    .AddGraphQLServer()
    .AddType<ProcessType>()
    .AddType<DocumentType>()
    .AddQueryType<Query>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGraphQL();

app.Run();
