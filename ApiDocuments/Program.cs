using ApiDocuments;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<DocumentModel> books = [
  new DocumentModel(
    Id: new("f46348e7-c4be-40d9-9e32-cdd0e18ef635"),
    Title: "The book of the world",
    Description: "t, consectetur adip eu fugiat n  dolor sit ame"
  ),
  new DocumentModel(
    Id: new("2903c644-9b33-4684-a0c1-25f1de998edd"),
    Title: "The book is on the table ofContents",
    Description: "t, consectetur adip eu fugiat n  dolor sit ame"
  ),
  new DocumentModel(
    Id: new("251d8cd9-98f8-415a-8a40-d06b9be95a3d"),
    Title: "Le mot de actifie",
    Description: "t, consectetur adip eu fugiat n  dolor sit ame"
  ),
];

app.MapGet("/{id}", (Guid id) => Results.Ok(books.FirstOrDefault(book => book.Id == id)));

app.Run();
