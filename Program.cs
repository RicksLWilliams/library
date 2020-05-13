using System;
using Library.Models;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            xLibrary myLibrary = new xLibrary("location", "name");

            Book whereTheSidewalkEnds = new Book("Where the Sidewalk Ends", "Shel Silverstein");
            myLibrary.AddBook(whereTheSidewalkEnds);
            
            Book theHobbit = new Book("The Hobbit", "J.R.R. Tolkie");
            myLibrary.AddBook(theHobbit);
            
            Book theLion = new Book("The Lion, The Witch, and the Wardrobe", "C.S. Lewis");
            myLibrary.AddBook(theLion);
            
            Book harryPotter = new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling");
            myLibrary.AddBook(harryPotter);
            
            Console.Clear();
            Console.WriteLine($"Welcome to The {myLibrary.Name} Library at {myLibrary.Location}!");
            Console.WriteLine("");
            Console.WriteLine("Available Books:");
            myLibrary.PrintBooks();
            Console.WriteLine("");
            Console.WriteLine("Select a book number to checkout (Q)uit, or (R)eturn a book");
        
        }
    }
}
