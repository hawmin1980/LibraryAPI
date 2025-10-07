using AutoMapper;
using LibraryAPI.Data;
using LibraryAPI.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<LibraryAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LibraryAPIContext") ?? throw new InvalidOperationException("Connection string 'LibraryAPIContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//builder.Services.AddAutoMapper(cfg =>
//{
//    cfg.AddProfile(new MemberProfile());
//});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "api");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
