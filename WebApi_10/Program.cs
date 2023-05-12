using Microsoft.EntityFrameworkCore;
using WebApi_10.Data;
using WebApi_10.Respositories.Abstract;
using WebApi_10.Respositories.Concrete;
using WebApi_10.Services.Abstract;
using WebApi_10.Services.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var connection = builder.Configuration.GetConnectionString("myconn");
builder.Services.AddDbContext<Store2DBContext>(opt =>
{
    opt.UseSqlServer(connection);
});
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProdcutService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<ICustomersRepository,CustomerRepository>();
builder.Services.AddScoped<ICustomerServices, CustomerService>();

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
