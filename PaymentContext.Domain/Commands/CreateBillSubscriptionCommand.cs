using Flunt.Validations;
using Flunt.Notifications;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Commands;

public class CreateBillSubscriptionCommand : Notifiable<Notification>, ICommand
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Document { get; set; }
    public string? Email { get;  set; }
    public string? BarCode { get;  set; }
    public string? BillNumber { get;  set; }
    public string? PaymentNumber { get; set; }
    public DateTime PaidDate { get;  set; }
    public DateTime ExpireDate { get;  set; }
    public decimal Total { get;  set; }
    public decimal TotalPaid { get;  set; }
    public string? Payer { get;  set; }
    public string? PayerDocument { get;  set; }
    public EDocumentType? PayerDocumentType { get; set; }
    public string? PayerEmail { get;  set; }
    public string? Street { get;  set; }
    public string? Number { get;  set; }
    public string? Neighborhood { get;  set; }
    public string? City { get;  set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? ZipCode { get; set; }
    public bool Invalid { get; internal set; }

    public void Validate()
     { 
        AddNotifications(new Contract<Notification>()
            .Requires()
            .IsGreaterThan(FirstName, 3, "Name.FirstName", "Your Name must contain at least 3 characters.")
            .IsGreaterThan(LastName, 3, "Name.LastName", "Your Last Name must contain at least 3 characters.")
            .IsLowerThan(FirstName, 40, "Name.FirstName", "Your Name must contain max 40 characters")
            .IsLowerThan(LastName, 40, "Name.LastName", "Your Last Name must contain max 40 characters")); 
    }
}


