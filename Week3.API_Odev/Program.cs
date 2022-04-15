using MediatR;
using Npgsql;
using System.Data;
using System.Reflection;
using Week3.API_Odev.Filters;
using Week3.API_Odev.Middlewares;
using Week3.API_Odev.Repositories.Abstract;
using Week3.API_Odev.Repositories.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ExceptionFilter>();
builder.Services.AddScoped<ValidateFilter>();



builder.Services.AddScoped<IDbConnection>(sp => new NpgsqlConnection(builder.Configuration.GetConnectionString("Postgresql")));
builder.Services.AddScoped<ICarRepository, CarRepository>();

builder.Services.AddScoped<IDbTransaction>(sp =>
{

    var connection = sp.GetRequiredService<IDbConnection>();
    connection.Open();
    return connection.BeginTransaction();


});

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//custom middleware
app.UseGlobalExceptionMiddleware();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
