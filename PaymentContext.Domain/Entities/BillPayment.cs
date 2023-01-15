namespace PaymentContext.Domain.Entities
{
    public class BillPayment : Payment
    {
        public BillPayment(
            string? barCode,
            string? billNumber,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string? payer,
            string? document,
            string? adress,
            string? email)
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
            BarCode = barCode;
            BillNumber = billNumber;
        }

        public string? BarCode { get; private set; }
        public string? BillNumber { get; private set; }
    }

}