using System;
using System.Collections.Generic;
//using Library.Models;

namespace Library.Models
{
  public class xLibrary
  {
    public string Location { get; set; }
    public string Name { get; set; }
    private List<Book> Books { get; set; }

    public xLibrary(string location, string name)
    {
      Location = location;
      Name = name;
      Books = new List<Book>();
    }
    public void PrintBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        Console.WriteLine($"{i + 1} {Books[i].Title} - {Books[i].Author}");
      }
    }
    public void AddBook(Book book)
    {
      Books.Add(book);
    }

  }

}