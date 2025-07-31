var builder = WebApplication.CreateBuilder(args);

// CORS for local Blazor dev (adjust ports if your Blazor runs somewhere else)
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.WithOrigins("https://localhost:5001", "https://localhost:7260") // update if needed
            .AllowAnyHeader()
            .AllowAnyMethod());
});

builder.Services.AddControllers();

var app = builder.Build();

app.UseCors();
app.MapControllers();

app.Run();
