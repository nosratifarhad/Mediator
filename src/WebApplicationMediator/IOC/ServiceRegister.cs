using WebApplicationMediator.Service;

namespace WebApplicationMediator.IOC
{
    public static class ServiceRegister
    {
        public static void AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
