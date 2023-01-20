using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Commands;

public class CommandResult : ICommandResult
{
    public CommandResult(bool success, string? message) 
        => (Success, Message) = (success, message);
        
    public CommandResult(){}
    public bool Success { get; set; }
    public string? Message { get; set; }       
}
