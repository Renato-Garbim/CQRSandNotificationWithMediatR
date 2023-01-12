using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorNotifications
{
    public static class NotifyModule
    {
        public static IServiceCollection AddNotifyModule(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddMediatR(typeof(NotifyModule).Assembly);

            return serviceCollection;
        }
    }
}
