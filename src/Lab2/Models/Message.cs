namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public record Message(string TextMessage)
{
    public const string Incompatible = "Incompatible components: ";
    public const string DisclaimerOfWarrantyDueTo = "Disclaimer of warranty due to: ";
    public const string ConditionalComponent = "Missing conditional component: ";
    public const string Success = "Success";
}