using MediatR;
using WalletService.Application.CQRS.command.Create;

//using Wallet.Application.CQRS.command.Create;
//using Wallet.Application.CQRS.command.UpdateBalance;
//using Wallet.Application.CQRS.Querries;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(typeof(Program)); //Регистрация медиатра

builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddMediatR(typeof(CreateWalletСommand)); //регистрация СQRS команд


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


//app.UseHttpsRedirection();
//.UseAuthorization();

app.MapControllers();

app.Run();
