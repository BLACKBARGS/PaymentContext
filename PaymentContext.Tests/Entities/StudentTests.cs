using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var subscription = new Subscription(null);
            var student = new Student("Francys", "Rodrigues", "601.855.120-97", "blackgsgofsr@gmail.com");
            student.AddSubscription(subscription);

        }
    }
}