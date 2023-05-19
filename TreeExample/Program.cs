using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using BusinessLayer.Services.Utils;
using DB;
using DB.Repositories;
using DB.Repositories.Interfaces;
using TreeExample;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add context
var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContext");
builder.Services.AddSqlServer<ApplicationDbContext>(connectionString);
builder.Services.AddScoped<IMigrateDbCtrl, MigrateDbCtrl>();

builder.Services.AddScoped<IExcelImport, ExcelImport>();
builder.Services.AddScoped<IExcelExportGeneric, ExcelExportGeneric>();


builder.Services.AddScoped<IActionRepository, ActionRepository>();
builder.Services.AddScoped<IApplicationRepository, ApplicationRepository>();
builder.Services.AddScoped<ITreeViewRepository, TreeViewRepository>();


builder.Services.AddScoped<IPermissionService, PermissionService>();

// Add MapperConfig
builder.Services.AddAutoMapper(typeof(MapperConfig));

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