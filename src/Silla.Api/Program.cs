using Microsoft.EntityFrameworkCore;
using Silla.Infrastructure.Data;
using Silla.Infrastructure.Repositories;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<AppDbContext>(opts =>
    opts.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

// Allow the Blazor origin 
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.WithOrigins("https://localhost:7190") // Blazor WASM origin
            .AllowAnyHeader()
            .AllowAnyMethod());
});

builder.Services.AddScoped<IJournalEntryRepository, JournalEntryRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(); // must come before MapControllers()

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Silla API V1"));
}

app.MapControllers();
app.Run();