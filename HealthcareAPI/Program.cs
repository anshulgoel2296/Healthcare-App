using HealthcareAPI.AutoMapper;
using HealthcareAPI.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register the HealthcareAppDBContext with SQL Server provider
builder.Services.AddDbContext<HealthcareAppDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register controller services
builder.Services.AddControllers();

// Register AutoMapper services
builder.Services.AddAutoMapper(cfg => { }, typeof(HealthcareAppAutoMapper).Assembly);

// Register Swagger/OpenAPI services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    // Enable Swagger JSON endpoint
    app.UseSwagger();

    // Enable Swagger UI
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Map controller routes
app.MapControllers();

app.Run();