using Landscaping_WebApplication_API_.Repositories.Implementation;
using Landscaping_WebApplication_API_.Repositories.Interface;
using Landscaping_WebApplication_API_.Services.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

builder.Services.AddScoped<IGardenRepository, GardenRepository>();
builder.Services.AddScoped<IGardenService, GardenService>();

builder.Services.AddScoped<IGardenerRepository, GardenerRepository>();
builder.Services.AddScoped<IGardenerService, GardenerService>();

builder.Services.AddScoped<IPlantRepository, PlantRepository>();
builder.Services.AddScoped<IPlantService,PlantService>();

builder.Services.AddScoped<IIrrigationSystemRepository, IrrigationSystemRepository>();
builder.Services.AddScoped<IIrrigationSystemService, IrrigationSystemService>();

builder.Services.AddScoped<IMaintenanceTaskRepository, MaintenanceTaskRepository>();
builder.Services.AddScoped<IMaintenanceTaskService, MaintenanceTaskService>();


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
