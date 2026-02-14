using Interfaces;

namespace Notifications
{
    public class SmsNotification : INotification
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        private void Send()
        {
            Console.WriteLine($"📱 Enviando SMS para {PhoneNumber}");
            Console.WriteLine($"   Mensagem: {Message}");
        }
        public void SendOrderConfirmation(string recipient, string orderNumber)
        {
            this.PhoneNumber = recipient;
            this.Message = $"Seu pedido foi enviado! Código de rastreamento: {orderNumber}";
            Send();
        }
        public void SendShippingUpdate(string recipient, string trackingCode)
        {
            this.PhoneNumber = recipient;
            this.Message = $"Seu pedido foi enviado. Código de rastreio: {trackingCode}";
            Send();
        }
        public void SendPaymentReminder(string recipient, decimal amount)
        {
            this.PhoneNumber = recipient;
            this.Message = $"Você tem um pagamento pendente de {amount:C}.";
            Send();
        }
    }
}