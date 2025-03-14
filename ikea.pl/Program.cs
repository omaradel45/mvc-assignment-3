using ikea.dal.presistance.data;
using ikea.dal.presistance.repository.departments;
using Microsoft.EntityFrameworkCore;

namespace ikea.pl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region
            Configure services
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<applicationdbcontext>((optionsbuilder => optionsbuilder.UseSqlServer(builder.Configuration.GetConnectionString(defaultconnection);
            #endregion
            builder.Services.AddScoped<Idepartmentrepository, departmentrepository>();
            builder.Services.AddScoped<Idepartmentservice, departmentrservice>();
            // Add services to the container.
            builder.Services.AddControllersWithViews();

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
