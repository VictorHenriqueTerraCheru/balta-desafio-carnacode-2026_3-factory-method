using Factory;
using Interfaces;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Notificações ===\n");

        var factory = new NotificationFactory();

        // Cliente EMAIL
        Console.WriteLine("=== Cliente EMAIL ===");
        INotification emailNotification = factory.CreateNotification(EnumNotificationType.Email);
        emailNotification.SendOrderConfirmation("cliente@hotmail.com", "123456");
        Console.WriteLine();

        // Cliente SMS
        Console.WriteLine("=== Cliente SMS ===");
        INotification smsNotification = factory.CreateNotification(EnumNotificationType.SMS);
        smsNotification.SendOrderConfirmation("+5521999999999", "123456");
        Console.WriteLine();

        // Cliente PUSH
        Console.WriteLine("=== Cliente PUSH ===");
        INotification pushNotification = factory.CreateNotification(EnumNotificationType.Push);
        pushNotification.SendShippingUpdate("device-token-abc123", "BR123456789");
        Console.WriteLine();

        // Cliente WHATSAPP
        Console.WriteLine("=== Cliente WHATSAPP ===");
        INotification whatsappNotification = factory.CreateNotification(EnumNotificationType.WhatsApp);
        whatsappNotification.SendPaymentReminder("+5521888888888", 950.00m);
        Console.WriteLine();
    }
}
