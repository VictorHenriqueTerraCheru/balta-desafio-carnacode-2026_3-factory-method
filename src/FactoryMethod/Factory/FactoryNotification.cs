using Interfaces;
using Notifications;

namespace Factory
{
    public class NotificationFactory
    {
        public INotification CreateNotification(EnumNotificationType type)
        {
            return type switch
            {
                EnumNotificationType.Email => new EmailNotification(),
                EnumNotificationType.SMS => new SmsNotification(),
                EnumNotificationType.Push => new PushNotification(),
                EnumNotificationType.WhatsApp => new WhatsAppNotification(),
                _ => throw new ArgumentException($"Tipo '{type}' não suportado")
            };
        }
    }
}
