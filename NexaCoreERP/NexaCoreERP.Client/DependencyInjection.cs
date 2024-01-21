using NexaCoreERP.Client.HttpRespository;
using NexaCoreERP.Client.HttpRespository.Interfaces;

namespace NexaCoreERP.Client
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddClient(this IServiceCollection services, Uri uri)
        {
            services.AddHttpClient("NexaCoreErp",(sp,client) =>
            {
                client.BaseAddress = uri;
                client.Timeout = TimeSpan.FromSeconds(5);
            });

            services.AddScoped(sp=>
            sp.GetService<IHttpClientFactory>().CreateClient("NexaCoreErp"));

            services.AddScoped<IProductHttpRepository, 
                ProductHttpRepository>();

            return services;
        }
    }
}
