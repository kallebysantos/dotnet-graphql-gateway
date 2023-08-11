namespace ApiProcess;

public record ProcessModel(
  Guid Id, IEnumerable<Guid> Documents, string Author, string Description
);