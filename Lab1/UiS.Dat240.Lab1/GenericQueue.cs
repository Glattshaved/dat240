using UiS.Dat240.Lab1.Queues;
using System.Collections;
using System.Collections.Generic;

public class GenericQueue<T> : IGenericQueue<T>, IEnumerable<T>
{
    T[] queue;
    int head;
    int tail;
    int count;

    //Initializing variables
    public GenericQueue()
    {
        queue = new T[4];
        head = 0;
        tail = 0;
        count = 0;        
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < count; i++)
        {
            yield return queue[(head + i) % queue.Length];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();  // Delegate to the generic version
    }

    // Read-only variable Length
    public int Length => count;

    public void Enqueue(T value)
    {
        if (count == queue.Length)
        {
            Grow();
        }

        queue[tail] = value;
        tail = (tail + 1) % queue.Length;
        count++;
    }

    public T Dequeue()
    {
        if(count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        T value = queue[head];

        //Sets the type to default (empty)
        queue[head] = default(T);
        head = (head + 1) % queue.Length;
        count--;

        return value;
    }

    private void Grow()
    {
        T[] newQueue = new T[queue.Length * 2];

        for (int i = 0; i < count; i++)
        {
            newQueue[i] = queue[(head + i) % queue.Length];
        }

        queue = newQueue;
        head = 0;
        tail = count;
    }
}