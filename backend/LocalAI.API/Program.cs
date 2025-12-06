var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Upload document
app.MapPost("/api/documents", (HttpRequest request) =>
{
    // TODO: Implement storage & indexing
    return Results.Ok(new { id = Guid.NewGuid().ToString(), status = "stored" });
});

// Basic search endpoint
app.MapPost("/api/search", (dynamic body) =>
{
    // TODO: Implement semantic search
    return Results.Ok(new { results = new[] { new { docId = "test", score = 1.0, snippet = "Hello" } } });
});

app.Run();
