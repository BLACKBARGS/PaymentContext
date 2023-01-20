using PaymentContext.Shared.ValueObjects;
using PaymentContext.Domain.Enums;
using Flunt.Validations;

namespace PaymentContext.Domain.ValueObjects;

public class Document : ValueObject
{
    private string? payerDocument;
    private EDocumentType? payerDocumentType;

    public Document(string number, EDocumentType type)
    {
        Number = number;
        Type = type;
        AddNotifications(new Contract<Document>()
        .Requires()
        .IsTrue(Validate(), "Document.Number", "Documento Invalido"));
    }

    

    public string Number { get; private set; }
    public EDocumentType Type { get; private set; }
    public bool Invalid { get; set; }

    private bool Validate()
    {
        if(Type == EDocumentType.CNPJ && Number.Length == 14)
            return true;
        if(Type == EDocumentType.CPF && Number.Length == 11)
            return true;
        return false;
    }
}