using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests;

[TestClass]
public class DocumentTests
{    
    [TestMethod]
    public void ShouldReturnErrorWhenCNPJIsInvalid(string CNPJ)
    {
        var doc = new Document("123", EDocumentType.CPF);
        Assert.IsTrue(doc.Invalid);
    }

    [TestMethod]
    public void ShouldReturnErrorWhenCNPJIsValid()
    {
        var doc = new Document("12345687537834", EDocumentType.CNPJ);
        Assert.IsTrue(doc.IsValid);
    }

    [TestMethod]
    public void ShouldReturnErrorWhenCPFIsValid()
    {
        var doc = new Document("60232085097", EDocumentType.CPF);
        Assert.IsTrue(doc.IsValid);
    }

    [TestMethod]
    public void ShouldReturnErrorWhenCPFIsInvalid()
    {
        var doc = new Document("60132111512097", EDocumentType.CPF);
        Assert.IsTrue(doc.Invalid);
    }
}