using PaymentContext.Shared.Entities;
using PaymentContext.Domain.ValueObjects;
namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private readonly IList<Subscription> _subscriptions;

        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public Name Name { get; private set; } 
        public Document Document { get; private set; } 
        public Email Email { get; private set; } 
        public Address? Address { get; private set; } 

        // Alteração: foi adicionado o readonly para a propriedade Subscriptions, pois ela não será alterada no código e assim não precisa de um método para alterar seu valor. 

        public IReadOnlyCollection<Subscription> Subscriptions => _subscriptions.ToArray();

        public void AddSubscription(Subscription subscription) 
        { 

            // Alteração: foi removido o if (Subscriptions != null), pois a propriedade Subscriptions já é inicializada com uma lista vazia e não pode ser nula.  

            foreach (var sub in Subscriptions) 
            { 
                sub.Inactivate(); 
            } 

            _subscriptions.Add(subscription); 

        } 

    } 
}