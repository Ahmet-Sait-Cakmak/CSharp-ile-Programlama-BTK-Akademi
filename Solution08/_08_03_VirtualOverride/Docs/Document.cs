using System;
using System.Runtime.CompilerServices;

namespace Docs;

  public class Document
 {
    public String Title { get; set; }

    public Document(string title)
    {
        Title = title;
    }

    public virtual void Print()
    {
        Console.WriteLine($"Belge yazdiriliyor: {Title}");
    }
}
