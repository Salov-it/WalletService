using System.Reflection;
using WalletServic.Application;
using WalletService.Application.Interface;
using WalletService.Application.Mapping;
using WalletService.infrastructure;

var builder = WebApplication.CreateBuilder(args);


IConfiguration configuration = builder.Configuration;

builder.Services.AddAutoMapper(config =>
{
    config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
    config.AddProfile(new AssemblyMappingProfile(typeof(IWalletContext).Assembly));

});
builder.Services.AddApplication();
builder.Services.AddPersistance(configuration);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var serviseProvider = scope.ServiceProvider;
    try
    {
        var context = serviseProvider.GetRequiredService<WalletContext>();
        DbInit.init(context);
    }
    catch (Exception ex)
    {

    }
};

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
