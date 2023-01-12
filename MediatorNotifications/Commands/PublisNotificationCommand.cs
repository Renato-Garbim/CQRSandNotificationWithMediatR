using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorNotifications.Commands
{
    public class PublisNotificationCommand : INotification
    {
        public string Message { get; set; }
    }
}
