using B3.Domain.Interfaces;
using B3.Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace B3.Application.DI {
    public class Initializer {
        public static void Configure (IServiceCollection services, string conection) 
        {

            services.AddScoped<ICDBService, CDBService>();
        }
    }
}