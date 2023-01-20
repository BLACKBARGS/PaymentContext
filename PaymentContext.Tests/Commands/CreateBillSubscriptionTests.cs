using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests;

    [TestClass]
    public class CreateBillSubscriptionCommandTests
    {
 
    [TestMethod]
    public void ShouldReturnErrorWhenNameIsInvalid()
    {
       var command = new CreateBillSubscriptionCommand();
       command.FirstName = "";
       command.Validate();

       Assert.AreEqual(false, command.IsValid);
    }
}