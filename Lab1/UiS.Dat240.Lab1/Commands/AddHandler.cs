using UiS.Dat240.Lab1.Commands;
using UiS.Dat240.Lab1.Queues;

public class AddHandler : ICommandHandler
{
    public string Name => "add";

    private readonly IGenericQueue<string> _queue;
    public AddHandler(IGenericQueue<string> queue)
    {
        _queue = queue;
    }

    public void Handle(string args)
    {
        _queue.Enqueue(args);
        Console.WriteLine($"\nYou added: \"{args}\".");
        Console.WriteLine("Type \"exit\" to terminate the program, or continue using the commands.");
    }
}