using Microsoft.EntityFrameworkCore;
using Pizzaria2._0.Data;
using Pizzaria2._0.Data.Repository.Interfaces;
using Pizzaria2._0.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configura��o do banco de dados
var connectionstring = builder.Configuration.GetConnectionString("StringConexao");
builder.Services.AddDbContext<DataBaseContext>(options => options.UseSqlServer(connectionstring));

// Registra o reposit�rio de autentica��o
builder.Services.AddScoped<IAccountRepository, AccountRepository>();

// Configura��o de autentica��o por cookies

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
