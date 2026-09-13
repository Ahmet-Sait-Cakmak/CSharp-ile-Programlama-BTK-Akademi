class Library : ILibraryService
{
    private readonly SortedList<int, Book> books;

    public Library()
    {
        books = new SortedList<int, Book>();
    }

    public void AddBook(Book book)
    {
        if (books.ContainsKey(book.ID))
        {
            System.Console.WriteLine($"ID'si {book.ID} olan bir kitap zaten mevcut!");

            return;
        }

        books.Add(book.ID, book);

        System.Console.WriteLine($"{book.title} basarili bir sekilde eklendi.");
    }

    public void PrintAll()
    {
        System.Console.WriteLine("\n=== Kitap Listesi ===\n");

        foreach (var b in books)
        {
            System.Console.WriteLine(b.Value);
        }
    }

    public void RemoveAtPosition(int index)
    {
        if (index < 0 || index > books.Count)
        {
            System.Console.WriteLine("\nGecersiz indeks!\n");

            return;
        }

        int key = books.Keys[index];

        books.RemoveAt(index);

        System.Console.WriteLine($"\n{index}. indexteki kitabin ID'si {key} idi ve bu kitap silindi.\n");
    }

    public bool RemoveBookById(int id)
    {
        bool removed = books.Remove(id);

        System.Console.WriteLine(removed ? $"\nID'si {id} olan kitap silindi.\n" : $"\nID numarasi {id} olan bir kitap bulunammadi.\n");

        return removed;
    }

    public bool TryFindById(int id, out Book book)
    {
       bool isExist = books.TryGetValue(id, out book);

       System.Console.WriteLine(isExist ? $"\nID'si {id} olan kitap bulundu." : $"ID'si {id} olan kitap bulunamadi.\n");

       return isExist;
    }

    public int IndexOfId(int id) => books.IndexOfKey(id);
}