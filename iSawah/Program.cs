using iSawah.Application.Config;
using iSawah.Application.Services.Customers;
using iSawah.Application.Services.Distributors;
using iSawah.Application.Services.Fields;
using iSawah.Application.Services.Statuses;
using iSawah.Application.Services.TransactionDetails;
using iSawah.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// DbContext
var connectionString = builder.Configuration.GetConnectionString("Database");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

// Add AutoMapper
var config = new AutoMapper.MapperConfiguration(cfg =>
{
	cfg.AddProfile(new ConfigProfile());
});
var mapper = config.CreateMapper();

// Add services to the container.
builder.Services.AddSingleton(mapper);
builder.Services.AddTransient<ICustomerAppService, CustomerAppService>();
builder.Services.AddTransient<IFieldAppService, FieldAppService>();
builder.Services.AddTransient<IOwnerAppService, OwnerAppService>();
builder.Services.AddTransient<ITransactionAppService, TransactionAppService>();
builder.Services.AddTransient<ITransactionDetailAppService, TransactionDetailAppService>();
builder.Services.AddTransient<IStatusAppService, StatusAppService>();

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
