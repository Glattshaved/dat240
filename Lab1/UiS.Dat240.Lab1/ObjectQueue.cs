using UiS.Dat240.Lab1.Queues;

public class ObjectQueue : IObjectQueue
{
    private GenericQueue<object> internalQueue = new GenericQueue<object>();

    // Read-only variable Length
    public int Length => internalQueue.Length;

    public void Enqueue(object value)
    {
        internalQueue.Enqueue(value);
    }

    public object Dequeue()
    {
        return internalQueue.Dequeue();
    }

    /* private void Grow()
    {
        object[] newQueue = new object[queue.Length * 2];

        for (int i = 0; i < count; i++)
        {
            newQueue[i] = queue[(head + i) % queue.Length];
        }

        queue = newQueue;
        head = 0;
        tail = count;
    } */
}