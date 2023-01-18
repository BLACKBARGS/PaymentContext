using PaymentContext.Shared.Entities;
using PaymentContext.Domain.ValueObjects;
using Flunt.Validations;

namespace PaymentContext.Domain.Entities;
    public class Student : Entity
{
    private readonly IList<Subscription> _subscriptions;
    public Student(Name name, Document document, Email email)
    {
        Name = name;
        Document = document;
        Email = email;
        _subscriptions = new List<Subscription>(); 
        AddNotifications(name, document, email);
    }
public Name Name { get; private set; } 
public Document Document { get; private set; } 
public Email Email { get; private set; } 
public Address? Address { get; private set; } 
public IReadOnlyCollection<Subscription> Subscriptions => _subscriptions.ToArray();
    public void AddSubscription(Subscription subscription) 
    { 
    var hasSubscriptionActive = false;
    foreach (var sub in _subscriptions)
    if (sub.Active)
    hasSubscriptionActive = true;
    AddNotifications(new Contract<Student>()
    .Requires()
    .IsFalse(hasSubscriptionActive, "Student.Subscriptions", "You have an active Subscription!")
    );
    } 
}