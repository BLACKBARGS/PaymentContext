using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests;

[TestClass]
    public class StudentTests
{
[TestMethod]
    public void NewSubscription()
    {
        var name = new Name("Francys","Rodrigues");
        foreach(var not in name.Notifications)
        {
            //not.Message;
        }
    }
}