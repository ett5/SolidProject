
using Solid.Core.Mapping;
using Solid.Core.Repository;
using Solid.Core.Service;
using Solid.Data;
using Solid.Service;
using Web.Net.API.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IEmployeeService,EmployeeService>();
builder.Services.AddScoped<IHoursService,HoursService>();
builder.Services.AddScoped<ITasksService,TasksService>();
builder.Services.AddScoped<IEmployeeRepository,EmployeeRepository>();
builder.Services.AddScoped<ITasksRepository,TasksRepsitory>();
builder.Services.AddScoped<IHoursRepository,HoursRepository>();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddAutoMapper(typeof(MappingProfile), typeof(ApiMappingProfile));
//builder.Services.AddSingleton<DataContext>();
//builder.Services.AddControllers().AddJsonOptions(options =>
//{
//  options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
//    options.JsonSerializerOptions.WriteIndented = true;
//});

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
