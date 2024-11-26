namespace Commands.Abstractions;

public interface IHelloWorldCommand
{
    string Name { get; set; }

    string Handle();
}
