using Autofac.Core;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using System.Reflection;
using Wallet.Application;
using Wallet.infrastructure;
using static Wallet.WebApi.WeatherForecast;
using Wallet.WebApi;
using System.Net.NetworkInformation;
using Wallet.Application.CQRS.command;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(typeof(Program)); //Регистрация медиатра

builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddMediatR(typeof(CreateWalletСommand)); //регистрация СQRS команд





using (var scope = builder.Services.BuildServiceProvider().CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    try
    {
        var context = serviceProvider.GetRequiredService<WalletContext>();
        Dbinitialization.Initialize(context);
    }
    catch (Exception exception) 
    {

    }
}

    // Add services to the container.

    builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



app.Run();
