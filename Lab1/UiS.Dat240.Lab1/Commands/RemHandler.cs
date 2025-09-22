using UiS.Dat240.Lab1.Commands;
using UiS.Dat240.Lab1.Queues;

public class RemHandler : ICommandHandler
{
    public string Name => "rem";

    private readonly IGenericQueue<string> _queue;

    public RemHandler(IGenericQueue<string> queue)
    {
        _queue = queue;
    }

    public void Handle(string args)
    {
        try
        {
        string removedValue = _queue.Dequeue();
        Console.WriteLine($"\nYou removed \"{removedValue}\" from the head of the string.");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Queue is empty.");
        }
    }
}