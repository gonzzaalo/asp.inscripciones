using Inscripciones.Models;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

var configuration = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<InscripcionesContext>(options => options.UseSqlServer(configuration.GetConnectionString("sqlserver")));
string cadenaConexion = configuration.GetConnectionString("mysqlremoto") ;
builder.Services.AddDbContext<InscripcionesContext>(
    options => options.UseMySql(cadenaConexion,
                                ServerVersion.AutoDetect(cadenaConexion),
                    options => options.EnableRetryOnFailure(
                                        maxRetryCount: 5,
                                        maxRetryDelay: System.TimeSpan.FromSeconds(30),
                                       errorNumbersToAdd: null)
                                ));
// Configura el serializador JSON para manejar referencias cíclicas
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    });

//builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Configurar una política de CORS
=======

var builder = WebApplication.CreateBuilder(args);
var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();


// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddDbContext<InscripcionesContext>(options =>
//options.UseSqlServer(configuration.GetConnectionString("sqlserver")));

string cadenaConexion = configuration.GetConnectionString("mysqlremoto");
builder.Services.AddDbContext<InscripcionesContext>(options => options.UseMySql(cadenaConexion,
            ServerVersion.AutoDetect(cadenaConexion),
                                options => options.EnableRetryOnFailure(
                                        maxRetryCount: 5,
                                        maxRetryDelay: System.TimeSpan.FromSeconds(30),
                                       errorNumbersToAdd: null)
            ));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configurar una politica de CORS
>>>>>>> 22dffa65b1a09e04e32f7b43817b799fa45ab3ea
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder
<<<<<<< HEAD
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
});


=======
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod());
});

>>>>>>> 22dffa65b1a09e04e32f7b43817b799fa45ab3ea
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
<<<<<<< HEAD

=======
>>>>>>> 22dffa65b1a09e04e32f7b43817b799fa45ab3ea
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
<<<<<<< HEAD
=======

>>>>>>> 22dffa65b1a09e04e32f7b43817b799fa45ab3ea
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API V1");
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseCors("AllowAll");

<<<<<<< HEAD

=======
>>>>>>> 22dffa65b1a09e04e32f7b43817b799fa45ab3ea
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
