namespace Interfaces
{
    public interface INotification
    {
        void SendOrderConfirmation(string recipient, string orderNumber);
        void SendShippingUpdate(string recipient, string trackingCode);
        void SendPaymentReminder(string recipient, decimal amount);
    }
}
