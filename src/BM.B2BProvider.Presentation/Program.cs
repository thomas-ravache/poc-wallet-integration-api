using BM.B2BProvider.Presentation.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureDependencyInjection();

builder.Services.AddControllers();
builder.Services.AddHealthChecks();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHealthChecks("/health");
app.MapControllers();

app.UseHttpsRedirection();

await app.RunAsync();
