using PapAPI.Abstraction;
using PapAPI.BAL;
using PapAPI.DataAccess;
using PapAPI.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Serilog; 
using MongoDB.Driver;
using PapAPI.Rest.Global.Excepcion;
using System.Net;
using PapAPI.Abstraction.DBContext;
using SumaAPI.Repository.Dominio;
using SumaAPI.BAL.Dominio;

var builder = WebApplication.CreateBuilder(args);


//string ruta = Directory.GetCurrentDirectory();
//builder.Configuration.SetBasePath(ruta).AddJsonFile("appsettings.json");

//builder.AddJsonFile("appsettings.json", optional: true);

/**
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", false, true)
    .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", false, true)
    .AddEnvironmentVariables();**/


/*Definicion de la configuracion para CORS*/

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder
                            .AllowAnyHeader()
                            .WithMethods("POST", "GET", "PUT", "DELETE")
                            .WithOrigins("http://localhost:4200") // Parametrizar
                            .AllowCredentials();
                      });
});

builder.Host.UseSerilog((context, config) =>
{
    config.ReadFrom.Configuration(context.Configuration);
    config.Enrich.FromLogContext();
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


/*Definición del String de conexion a la Base de Datos*/
var connectionString = builder.Configuration.GetConnectionString("DBCenitConnection");
builder.Services.AddDbContext<APIDBContext>(options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly("PapAPI.Rest")));

/*Definicion de la configuracion para JWT*/
builder.Services.Configure<JWTConfig>(builder.Configuration.GetSection("JwtConfig"));


builder.Services.AddAuthentication( options =>
{

    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer( jwt =>
{
    var jwtconf = builder.Configuration.GetSection("JwtConfig").Get<JWTConfig>();
    var key = Encoding.ASCII.GetBytes(jwtconf.Secret);
    jwt.SaveToken = true;
    jwt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false,
        RequireExpirationTime = false,
        ValidateLifetime = true,
    };
});



builder.Services.AddScoped(typeof(IDBContext<>), typeof(DBContext<>));
builder.Services.AddScoped(typeof(SumaRepository<>), typeof(SumaRepository<>));
builder.Services.AddScoped(typeof(SumaBAL<>), typeof(SumaBAL<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();

app.UseMiddleware<ExceptionMiddleware>();

//app.UseHttpsRedirection();

app.UseRouting();


app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.UseStaticFiles();


app.Run();
