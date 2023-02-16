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
using Wallet.Application.CQRS.command.UpdateBalance;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(typeof(Program)); //Регистрация медиатра

builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddMediatR(typeof(CreateWalletСommand)); //регистрация СQRS команд

builder.Services.AddMediatR(typeof(UpdateBalanceCommand)); //регистрация СQRS команд

//проверка базы данных 
var db = new WalletContext();
bool isCreated = db.Database.EnsureCreated();
if (isCreated) Console.WriteLine("База данных была создана");
else Console.WriteLine("База данных уже существует");



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
