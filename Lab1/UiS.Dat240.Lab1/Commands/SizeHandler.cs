using UiS.Dat240.Lab1.Commands;
using UiS.Dat240.Lab1.Queues;

public class SizeHandler : ICommandHandler
{
    public string Name => "size";

    private readonly IGenericQueue<string> _queue;

    public SizeHandler(IGenericQueue<string> queue)
    {
        _queue = queue;
    }

    public void Handle(string args)
    {
        Console.WriteLine($"Queue size: {_queue.Length}");
    }
}