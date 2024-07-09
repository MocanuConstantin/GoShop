using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using GoShop.Domain;
using GoShop.Data;
using GoShop.Core.Services;
using GoShop.Data.Repositories;
using GoShop.Domain.Interfaces;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMobilePhoneService, MobilePhoneService>();
builder.Services.AddScoped<IMobilePhoneRepository, MobilePhoneRepository>();
builder.Services.AddScoped<IMobilePhoneHardwareService, MobilePhoneHardwareService>();
builder.Services.AddScoped<IMobilePhoneHardwareRepository, MobilePhoneHardwareRepository>();
builder.Services.AddScoped<IMobilePhoneSoftwareService, MobilePhoneSoftwareService>();
builder.Services.AddScoped<IMobilePhoneSoftwareRepository, MobilePhoneSoftwareRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddDbContext<GoShopDbContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("GoShopDatabase")));

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
