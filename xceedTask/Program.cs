using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using xceedTask.Models;
using xceedTask.Repository;

namespace xceedTask
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			builder.Services.AddDbContext<MyContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("cs")));
			builder.Services.AddIdentity<ApplicationUser, IdentityRole>(
				options => {
					options.Password.RequiredLength = 4;
					options.Password.RequireNonAlphanumeric = false;
					options.Password.RequireUppercase = false;
					}
				).AddEntityFrameworkStores<MyContext>();

            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<IEmployeeLOFRepository, EmployeeLOFRepository>();
            builder.Services.AddScoped<IRepository<EmployeeLanguage>, EmployeeLanguageRepository>();
            builder.Services.AddScoped<IRepository<Language>, LanguageRepository>();
            builder.Services.AddScoped<IRepository<Account>, AccountRepository>();
            builder.Services.AddScoped<IRepository<LineOFBusiness>, LinesOfBusinessRepository>();
            

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

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}