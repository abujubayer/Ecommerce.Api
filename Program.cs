using Microsoft.EntityFrameworkCore;
using ECommerce.API.DataContext;
using ECommerce.API.interfaces;
using ECommerce.API.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ECommDbContext>(options=>
options.UseSqlServer(builder.Configuration.GetConnectionString("ECommerce"))
);

builder.Services.AddScoped<ICategroryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
//builder.Services.AddTransient<ICategroryRepository, CategoryRepository>();
//builder.Services.AddSingleton<ICategroryRepository, CategoryRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
