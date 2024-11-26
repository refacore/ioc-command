using Microsoft.AspNetCore.Mvc;
using Commands.Abstractions;
using Commands.Formatters;

namespace Commands;

public class HelloWorldCommand : IHelloWorldCommand
{
    [FromQuery]
    public string Name { get; set; } = string.Empty;

    private readonly StringFormatter stringFormatter;

    public HelloWorldCommand(StringFormatter stringFormatter)
    {
        this.stringFormatter = stringFormatter;
    }

    public string Handle()
    {
        return $"Hello {stringFormatter.Format(Name)}";
    }
}
