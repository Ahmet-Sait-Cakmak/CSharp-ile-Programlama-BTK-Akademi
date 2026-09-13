class ServiceDesk 
{
    private readonly Queue<Ticket> queue;

    public ServiceDesk() 
    {
        queue = new Queue<Ticket>();
    }

    public int Count => queue.Count;

    public void Enqueue(Ticket ticket) 
    {
        queue.Enqueue(ticket);

        Console.WriteLine($"{ticket} kuyruga eklendi.");
    }

    public void PeekNext()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine($"\nKuyruk bos!\n");

            return;
        }

        Console.WriteLine($"\nSiradaki deger: {queue.Peek()}\n");
    }

    public void ProcessNext()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine($"\nIslenecek bilet yok!\n");

            return;
        }

        var ticket = queue.Dequeue();

        ticket.Process();
    }

    public void PrintQueue() 
    {
        Console.WriteLine("\n=== Kuyruk ===\n");

        if (queue.Count == 0) 
        {
            Console.WriteLine("Kuyruk bos!");

            return;
        }

        foreach (var ticket in queue)
        {
            Console.WriteLine(ticket);
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}
