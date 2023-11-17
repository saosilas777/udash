
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using UDash.Data;
using UDash.Repositories;
using System.Text;
using static System.Collections.Specialized.BitVector32;
using UDash.Interfaces;

var builder = WebApplication.CreateBuilder(args);

string? conn = builder.Configuration.GetConnectionString(name: "DataBase");

builder.Services.AddDbContext<Context>(options =>
options.UseSqlServer((conn) ?? throw new InvalidOperationException("Connection string 'SistemaContatos' not found.")));
//Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();

builder.Services.AddScoped<IUserRepository, UserRepositories>();

builder.Services.AddHttpContextAccessor();
builder.Services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddCors();
/*var key = Encoding.ASCII.GetBytes(SettingsToken.Secret);*/

/*builder.Services.AddAuthentication(x =>
{
	x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
	x.RequireHttpsMetadata = true;
	x.SaveToken = true;
	x.TokenValidationParameters = new TokenValidationParameters
	{
		ValidateIssuerSigningKey = true,
		IssuerSigningKey = new SymmetricSecurityKey(key),
		ValidateIssuer = false,
		ValidateAudience = false,
		ClockSkew = TimeSpan.Zero,
		ValidateLifetime = true

	};
});*/


builder.Services.AddSession(obj =>
{
	obj.Cookie.HttpOnly = true;
	obj.Cookie.IsEssential = true;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCors(x => x
.AllowAnyOrigin()
.AllowAnyMethod()
.AllowAnyHeader());

app.UseAuthentication();
app.UseAuthorization();
app.UseSession();


app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Login}/{action=Login}/{id?}");

app.Run();
