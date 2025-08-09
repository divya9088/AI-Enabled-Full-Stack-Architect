var builder = WebApplication.CreateBuilder(args);

// Allow Angular dev server
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy  =>
        {
            policy.WithOrigins("http://localhost:4200")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

// Swagger for local testing
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);

// Minimal test endpoints
app.MapGet("/", () => "Hello from .NET API!");
app.MapGet("/api/time", () => new { serverTimeUtc = DateTime.UtcNow });
app.MapPost("/api/echo", (string input) => new { youSaid = input });

app.Run();
