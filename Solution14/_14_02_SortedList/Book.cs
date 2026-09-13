class Book
{
    public Book(int _ID, string _title, string _author)
    {
        ID = _ID;
        title = _title;
        author = _author;
    }

    public int ID { get; private set; }

    public String title { get; private set; }

    public String author { get; private set; }

    public void Rename(String newTitle) =>  title = newTitle;
    
    public void ChangeAuthor(String authorName) => author = authorName;

    public override string ToString() => $"{ID} {title} - {author}";
}
