using Interfaces;

namespace Notifications
{
    public class WhatsAppNotification : INotification
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public bool UseTemplate { get; set; }

        public void Configure(string recipient, string subject, string message)
        {
            this.PhoneNumber = recipient;
            this.Message = message;
            this.UseTemplate = true;
        }
        private void Send()
        {
            Console.WriteLine($"💬 Enviando WhatsApp para {PhoneNumber}");
            Console.WriteLine($"   Mensagem: {Message}");
            Console.WriteLine($"   Template: {UseTemplate}");
        }
        public void SendOrderConfirmation(string recipient, string orderNumber)
        {
            PhoneNumber = recipient;
            Message = $"Seu pedido foi enviado! Código de rastreamento: {orderNumber}";
            UseTemplate = true;
            Send();
        }
        public void SendShippingUpdate(string recipient, string trackingCode)
        {
            PhoneNumber = recipient;
            Message = $"Seu pedido foi enviado. Código de rastreio: {trackingCode}";
            UseTemplate = true;
            Send();
        }
        public void SendPaymentReminder(string recipient, decimal amount)
        {
            PhoneNumber = recipient;
            Message = $"Você tem um pagamento pendente de {amount:C}.";
            UseTemplate = true;
            Send();
        }
    }
}