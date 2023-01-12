using MediatR;
using Microsoft.Extensions.DependencyInjection;


namespace MediatorApplication
{
    public static class MediatorProductModule
    {
        public static IServiceCollection AddProductModule(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddMediatR(typeof(MediatorProductModule).Assembly);

            return serviceCollection;
        }
    }
}
