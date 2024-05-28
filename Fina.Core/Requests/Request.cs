namespace Fina.Core.Requests;

public abstract class Request 
{
    public string UserId { get; set; } = string.Empty;
}
// abstract: para impedir que outros objetos instanciem essa classe