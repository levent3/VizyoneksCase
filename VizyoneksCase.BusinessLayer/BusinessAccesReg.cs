using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VizyoneksCase.BusinessLayer.Abstract;
using VizyoneksCase.BusinessLayer.Concrete;

namespace VizyoneksCase.BusinessLayer
{
    public static class BusinessAccesReg
    {

        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {

            services.AddScoped<IProductService,ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICardService, CardManager>();
         


            return services;
        }

    }
}
