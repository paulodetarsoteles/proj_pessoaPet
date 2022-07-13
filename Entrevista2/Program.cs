using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Entrevista2.Data; 

var builder = WebApplication.CreateBuilder(args);

IConfiguration Configuration = builder.Configuration;

builder.Services.AddControllers(); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PessoaContext>
    (options => 
        {
            options
            .UseSqlServer(Configuration
            .GetConnectionString("Defaultconnection"));
        }
    );
builder.Services.AddControllers()
       .AddJsonOptions
       (
            options => options
            .JsonSerializerOptions
            .ReferenceHandler = ReferenceHandler
            .IgnoreCycles
       );

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();