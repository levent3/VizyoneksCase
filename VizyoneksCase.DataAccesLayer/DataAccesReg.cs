using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VizyoneksCase.DataAccesLayer.Abstract;
using VizyoneksCase.DataAccesLayer.Concrete;

namespace VizyoneksCase.DataAccesLayer
{
    public static class DataAccesReg
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Context>(options => {
                options.UseSqlServer(configuration.GetConnectionString("SqlDbContext"));
            });


            services.AddScoped<IProductDal, ProductRepository>();
            services.AddScoped<ICategoryDal, CategoryRepository>();      


            return services;
        }


    }
}
