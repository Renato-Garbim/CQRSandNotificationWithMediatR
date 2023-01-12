using CQRSAPIPOC.Commands;
using MediatorApplication;
using MediatorNotifications;
using MediatR;
using System.ComponentModel;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// MediatR

builder.Services.AddProductModule();
builder.Services.AddNotifyModule();

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
