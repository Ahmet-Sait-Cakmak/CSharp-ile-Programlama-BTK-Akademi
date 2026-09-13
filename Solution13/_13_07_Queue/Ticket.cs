class Ticket 
{

    public int ID { get; }

    public Customer customer { get; }

    public String topic { get; }

    public DateTime createdAt { get; }

    public Ticket(int _ID, Customer _customer, string _topic)
    {
        ID = _ID;
        customer = _customer;
        topic = _topic;
        createdAt = DateTime.Now;
    }

    public void Process() 
    {
        Console.WriteLine($"Isleniyor -> #{ID, -5} | {customer.FullName, -20} | {topic}");
    }

    public override string ToString() =>
    
        $"#{ID, -5} - {customer.FullName, -20} - {topic, -20} - {createdAt: HH:mm:ss}";
    
}