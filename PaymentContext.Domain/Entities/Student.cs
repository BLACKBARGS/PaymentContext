namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        public Student(string? firstName, string? lastName, string? document, string? email)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
        }

        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public string? Document { get; private set; }
        public string? Email { get; private set; }
        public string? Adress { get; private set; }
        public List<Subscription>? Subscriptions { get; set; }

        public void AddSubscription(Subscription subscription)
        {
            //Se ja tiver uma assinatura ativa, cancela
            //Cancela todas as outras assinaturas, e coloca esta como principal
            if (Subscriptions != null)
            {
                foreach (var sub in Subscriptions)
                {
                    sub.Active = false;
                }
            }

        }
    }
}