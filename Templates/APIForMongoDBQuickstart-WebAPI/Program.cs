using APIForMongoDBQuickstart_WebAPI.Models;
using APIForMongoDBQuickstart_WebAPI.Services;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton<MongoService>();
var connectionString = builder.Configuration["DatabaseSettings:MongoConnectionString"];
var databaseName = builder.Configuration["DatabaseSettings:DatabaseName"];
builder.Services.AddScoped(c => new MongoClient(connectionString).GetDatabase(databaseName));

builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
