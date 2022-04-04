using AutoMapper;
using KEM.EventManager.API.Extensions;
using KEM.EventManager.API.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Automapper configuration
var config = new MapperConfiguration(configuration => {
    configuration.AddProfile(new MappingProfileApi());
    });
var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);


// Project Specific Services
builder.Services.EventManagerServices();

// Add services to the container.
builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add corse
builder.Services.AddCors();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(policy => policy
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowCredentials()
    .WithOrigins("http://localhost:4200", "http://20.24.126.64")
);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
