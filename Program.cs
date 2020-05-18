using System;
using Library.Models;

namespace library
{
  class Program
  {
    static void Main(string[] args)
    {
      xLibrary myLibrary = new xLibrary("location", "name");
      bool inLibrary = true;

      Book whereTheSidewalkEnds = new Book("Where the Sidewalk Ends", "Shel Silverstein");
      Book theHobbit = new Book("The Hobbit", "J.R.R. Tolkie");
      Book theLion = new Book("The Lion, The Witch, and the Wardrobe", "C.S. Lewis");
      Book harryPotter = new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling");

      myLibrary.AddBook(whereTheSidewalkEnds);
      myLibrary.AddBook(theHobbit);
      myLibrary.AddBook(theLion);
      myLibrary.AddBook(harryPotter);

      Console.Clear();
      Console.WriteLine($"Welcome to The {myLibrary.Name} Library at {myLibrary.Location}!");

      while (inLibrary)
      {
        myLibrary.PrintBooks();
        string selection = Console.ReadLine();
        //add code for return --
        if (selection.ToLower() == "q")
        {
          inLibrary = false;
        } else if (selection.ToLower() == "r")
        {
          Console.WriteLine($"I need return code here ...");  
          //add some code here
        }
        else
        {
          myLibrary.Checkout(selection);
        }
        //inLibrary = (selection.ToLower() != "q");
      }
    }
  }
}
