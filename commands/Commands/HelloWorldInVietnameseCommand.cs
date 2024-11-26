using Microsoft.AspNetCore.Mvc;
using Commands.Abstractions;
using Commands.Formatters;

public class HelloWorldInVietnameseCommand : IHelloWorldCommand
{
    [FromQuery]
    public string Name { get; set; } = string.Empty;

    private readonly StringFormatter stringFormatter;

    public HelloWorldInVietnameseCommand(StringFormatter stringFormatter)
    {
        this.stringFormatter = stringFormatter;
    }

    public string Handle()
    {
        return $"Xin chào {stringFormatter.Format(Name)}";
    }
}
