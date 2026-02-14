using Interfaces;

namespace Notifications
{
    public class EmailNotification : INotification
    {

        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsHtml { get; set; }

        public void Configure(string recipient, string subject, string message)
        {
            this.Recipient = recipient;
            this.Subject = subject;
            this.Body = message;
            this.IsHtml = true;
        }
        private void Send()
        {
            Console.WriteLine($"📧 Enviando Email para {Recipient}");
            Console.WriteLine($"   Assunto: {Subject}");
            Console.WriteLine($"   Mensagem: {Body}");
        }
        public void SendOrderConfirmation(string recipient, string orderNumber)
        {
            Recipient = recipient;
            Subject = "Pedido Enviado";
            Body = $"Seu pedido foi enviado! Código de rastreamento: {orderNumber}";
            IsHtml = true;
            Send();
        }
        public void SendShippingUpdate(string recipient, string trackingCode)
        {
            Recipient = recipient;
            Subject = "Atualização de Envio";
            Body = $"Seu pedido foi enviado. Código de rastreio: {trackingCode}";
            IsHtml = false;
            Send();
        }
        public void SendPaymentReminder(string recipient, decimal amount)
        {
            Recipient = recipient;
            Subject = "Lembrete de Pagamento";
            Body = $"Você tem um pagamento pendente de {amount:C}.";
            IsHtml = false;
            Send();
        }
    }
}