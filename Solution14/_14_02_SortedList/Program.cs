ILibraryService library = new Library();

System.Console.WriteLine();
System.Console.WriteLine();

library.AddBook(new Book(30, "Domain Driven Design", "Eric Evans"));
library.AddBook(new Book(10, "Clean Code", "Robert Martin"));
library.AddBook(new Book(20, "The Pragmatic Programmer", "Andrew Hunt"));

library.PrintAll();

library.TryFindById(20, out Book book1);

library.RemoveAtPosition(0);

library.PrintAll();

var libImp = library as Library;

System.Console.WriteLine($"\n\nID'si 20 olan kitabin indeksi: {libImp?.IndexOfId(20)}\n");

Console.ReadKey();