using UiS.Dat240.Lab1.Queues;

public class StringQueue : IStringQueue
{
    private GenericQueue<string> internalQueue = new GenericQueue<string>();
    

    public int Length => internalQueue.Length;

    public void Enqueue(string value)
    {
        internalQueue.Enqueue(value);
    }

    public string Dequeue()
    {
         return internalQueue.Dequeue();
    }
}