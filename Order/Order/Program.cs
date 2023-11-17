using Infrastructura;
using Domain;
using Application;
using Application.Interfaces;
using Application.Interfaces.Repositories;
using Application.Servises;
using Infrastructura.Persistense.DBContext;
using Infrastructura.Persistense.Repository;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Application.Mapper.AutoMapper).Assembly);

builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IOrderItemService, OrderItemService>();
builder.Services.AddTransient<IProviderService, ProviderService>();

//Repositories
builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddDbContext<Context>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
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







//7.0.13 ������� ��