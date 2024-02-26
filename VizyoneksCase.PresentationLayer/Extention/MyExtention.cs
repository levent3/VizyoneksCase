using Microsoft.AspNetCore.Identity;
using VizyoneksCase.BusinessLayer.Abstract;
using VizyoneksCase.BusinessLayer.Concrete;

namespace VizyoneksCase.PresentationLayer.Extention
{
    public static class MyExtention
    {

        public static IServiceCollection AddManager(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
         

            return services;
        }
    }
}
