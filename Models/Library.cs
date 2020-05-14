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

    private List<Book> CheckedOut { get; set; }

    public xLibrary(string location, string name)
    {
      Location = location;
      Name = name;
      Books = new List<Book>();
      CheckedOut = new List<Book>();
    }
    public void PrintBooks()
    {
      //Console.Clear();
      //Console.WriteLine($"Welcome to The {myLibrary.Name} Library at {myLibrary.Location}!");
      Console.WriteLine("");
      Console.WriteLine("Available Books:");
      //myLibrary.PrintBooks();
      for (int i = 0; i < Books.Count; i++)
      {
        Console.WriteLine($"{i + 1} {Books[i].Title} - {Books[i].Author}");
      }
      Console.WriteLine("");
      Console.WriteLine("Select a book number to checkout (Q)uit, or (R)eturn a book");
    }
    public void AddBook(Book book)
    {
      Books.Add(book);
    }
    public void Checkout(String index)
    {
      Book selectedBook = ValidateBook(index, Books);
      if (selectedBook == null)
      {
        Console.Clear();
        System.Console.WriteLine(@"Invalid Selection
                ");
        return;
      }
      selectedBook.Available = false;
      CheckedOut.Add(selectedBook);
      Books.Remove(selectedBook);
      Console.WriteLine($"You have checked out {selectedBook.Title}");
    }
    private Book ValidateBook(String selection, List<Book> bookList)
    {
      int bookIndex = 0;
      bool valid = Int32.TryParse(selection, out bookIndex);
      if (!valid || bookIndex < 1 || bookIndex > bookList.Count)
      {
        return null;
      }
      return bookList[bookIndex - 1];
    }

  }

}