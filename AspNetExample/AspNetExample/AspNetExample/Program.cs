using AspNetExample.BusinessLayer.Services;
using AspNetExample.DataLayer;
using AspNetExample.DataLayer.Repositories;
using AspNetExample.Domain.Repositories;
using AspNetExample.Domain.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("DbConnection");

builder.Services.AddDbContext<EFContext>(opt =>
{
    opt.UseMySql(connectionString, ServerVersion.Parse("\r\n8.2.0-1.el8"));
});

builder.Services.AddTransient<IStudentServices, StudentServices>();
builder.Services.AddTransient<IStudentRepository, StudentRepository>();
builder.Services.AddTransient<ICourseService, CourseService>();
builder.Services.AddTransient<ICourseRepository,CourseRepository>();
builder.Services.AddTransient<IMarkService, MarkService>();
builder.Services.AddTransient<IMarkRepository, MarkRepository>();

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
