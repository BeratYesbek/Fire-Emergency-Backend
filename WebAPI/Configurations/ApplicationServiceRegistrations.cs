using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebAPI.Data;

namespace WebAPI.Configurations
{
    public static class ApplicationServiceRegistrations
    {
        public static IServiceCollection InitializeServices(this IServiceCollection service,IConfiguration configuration)
        {
            service.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("AppDbConnectionString")));



            return service;
        }
    }
}
