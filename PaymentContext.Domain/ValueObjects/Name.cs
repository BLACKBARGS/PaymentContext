using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects;
public class Name : ValueObject
{
    public Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        AddNotifications(new Contract<Name>()
        .Requires()
        .IsGreaterThan(FirstName, 3, "Name.FirstName", "Your Name must contain at least 3 characters.")
        .IsGreaterThan(LastName, 3, "Name.LastName", "Your Last Name must contain at least 3 characters.")
        .IsLowerThan(FirstName, 40, "Name.FirstName", "Your Name must contain max 40 characters")
        .IsLowerThan(LastName, 40, "Name.LastName", "Your Last Name must contain max 40 characters")
        );
    }
public string FirstName { get; set; }
public string LastName { get; set; }
}
