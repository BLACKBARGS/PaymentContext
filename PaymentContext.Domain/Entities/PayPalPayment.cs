using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
        public class PayPalPayment : Payment
    {
        public PayPalPayment(
            string? transactionCode,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string? payer,
            Document document,
            string? adress,
            Email email)
            :
            base(
                paidDate,
                expireDate,
                total,
                totalPaid,
                payer,
                document,
                adress,
                email)

        {
            TransactionCode = transactionCode;
        }

        public string? TransactionCode { get; private set; }
    }
}