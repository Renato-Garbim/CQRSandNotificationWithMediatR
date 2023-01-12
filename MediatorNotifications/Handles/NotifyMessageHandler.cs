using MediatorNotifications.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorNotifications.Handles
{
    public class NotifyMessageHandler : INotificationHandler<PublisNotificationCommand>
    {
        public Task Handle(PublisNotificationCommand notification, CancellationToken cancellationToken)
        {            
            Console.WriteLine($"Message: {notification.Message}");
            return Task.CompletedTask;
        }
    }
}
