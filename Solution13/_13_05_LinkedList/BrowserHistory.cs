internal class BrowserHistory
{
    private readonly LinkedList<string> history;

    private LinkedListNode<string> current;

    public BrowserHistory() 
    {
        history = new LinkedList<string>();
    }

    public void VisitPage(string url) 
    {
        if (current == null) 
        {
            current = history.AddFirst(url);
        }
        else 
        {
            while (current.Next != null) 
            {
                history.Remove(current.Next);
            }

            current = history.AddFirst(url);
        }

        Console.WriteLine($"Ziyaret: {url}");
    }

    public void Back() 
    {
        if (current?.Previous is not null) 
        {
            current = current.Previous;

            Console.WriteLine($"Gerideki deger: {current.Value}" );
        }
        else
        {
            Console.WriteLine("Gecmiste veri yok!");
        }
    }

    public void Forward()
    {
        if (current?.Next is not null)
        {
            current = current.Next;

            Console.WriteLine($"Ilerideki deger: {current.Value}");
        }
        else
        {
            Console.WriteLine("Ileride veri yok!");
        }
    }

    public void ShowHistory() 
    {
        Console.WriteLine("\n=== Tum Gecmis ===\n");

        for (var node = history.First; node != null; node = node.Next) 
        {
            var marker = node == current ? " <= current": "";

            Console.WriteLine($"{node.Value} {marker}");
        }
    }
}


