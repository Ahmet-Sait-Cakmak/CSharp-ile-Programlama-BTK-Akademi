var c1 = new Customer(1, "Fatma Yilmaz");
var c2 = new Customer(2, "Ali Demir");
var c3 = new Customer(3, "Zeynep Korkmaz");

var desk = new ServiceDesk();

desk.Enqueue(new Ticket(101, c1, "Sifre sifirlama"));
desk.Enqueue(new Ticket(102, c2, "Odeme Sorunu"));
desk.Enqueue(new Ticket(103, c3, "Giris Hatasi"));

desk.PrintQueue();

desk.PeekNext();

desk.ProcessNext();
desk.ProcessNext();

desk.PeekNext();

desk.PrintQueue();

desk.ProcessNext();
desk.ProcessNext();

Console.ReadKey();
