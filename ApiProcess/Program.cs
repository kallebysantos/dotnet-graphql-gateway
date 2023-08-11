using ApiProcess;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<ProcessModel> processes = [
  new ProcessModel(
    Id: Guid.NewGuid(),
    Author: "Fabian",
    Description: "Lorem ipsum dolor sit amet, consectetur adip eu fugiat nulla",
    Documents: [new("f46348e7-c4be-40d9-9e32-cdd0e18ef635")]
  ),
  new ProcessModel(
    Id: Guid.NewGuid(),
    Author: "John",
    Description: "The author of the process that was created",
    Documents: [
      new("2903c644-9b33-4684-a0c1-25f1de998edd"),
      new("251d8cd9-98f8-415a-8a40-d06b9be95a3d")]
  ),
];

app.MapGet("/",  () => Results.Ok(processes));

app.Run();
