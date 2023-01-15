namespace PaymentContext.Domain.ValueObjects
{
    public class Email
    {
        public Email(string address)
        {
            Address = address;
        }

        public string Address { get; private set; }

        public static implicit operator Email?(string? v)
        {
            throw new NotImplementedException();
        }
    }
}