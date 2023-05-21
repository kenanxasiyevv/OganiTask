using Microsoft.EntityFrameworkCore;
using OganiTask.DataAccessLayer;

namespace OganiTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddMvc();

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<AppDbContext>(builder =>
            {
                builder.UseSqlServer(connectionString);
            });

            var app = builder.Build();

            app.UseRouting();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>

                endpoints.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}")
            );

            app.Run();
        }
    }
}