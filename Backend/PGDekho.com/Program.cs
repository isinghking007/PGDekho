using Microsoft.EntityFrameworkCore;
using PGDekho.com.DataContext;
using PGDekho.com.Logic;
using PGDekho.com.Logic.Repositories;
using PGDekho.com.ServiceFolder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddTransient<IUnitOfWork,UnitOfWork>();
builder.Services.AddScoped<IPhotoService, PhotoService>();
builder.Services.AddCors();
builder.Services.AddControllers().AddNewtonsoftJson();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(m => m.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseAuthorization();

app.MapControllers();

app.Run();
