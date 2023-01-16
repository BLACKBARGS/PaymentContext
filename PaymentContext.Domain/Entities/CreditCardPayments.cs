using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(
            string? cardHolderName,
            string? cardNumber,
            string? lasTransactionNumber,
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
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LasTransactionNumber = lasTransactionNumber;
        }

        public string? CardHolderName { get; private set; }
        public string? CardNumber { get; private set; }
        public string? LasTransactionNumber { get; private set; }
    }

}