using PaymentContext.Domain.Enums;

namespace PaymentContext.Domain.Commands;

public class CreatePayPalSubscriptionCommand
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Document { get; set; }
    public string? Email { get;  set; }
    public string? TransactionCode { get;  set; }
    public string? PaymentNumber { get; set; }
    public DateTime PaidDate { get;  set; }
    public DateTime ExpireDate { get;  set; }
    public decimal Total { get;  set; }
    public decimal TotalPaid { get;  set; }
    public string? Payer { get;  set; }
    public string? PayerDocument { get;  set; }
    public EDocumentType PayerDocumentType { get; set; }
    public string? PayerEmail { get;  set; }
    public string? Street { get; private set; }
    public string? Number { get; private set; }
    public string? Neighborhood { get; private set; }
    public string? City { get; private set; }
    public string? State { get; private set; }
    public string? Country { get; private set; }
    public string? ZipCode { get; private set; }
}