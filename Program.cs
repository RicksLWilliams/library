using System;
using Library.Models;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Book whereTheSidewalkEnds = new Book("Where the Sidewalk Ends", "Shel Silverstein");
            Console.WriteLine(whereTheSidewalkEnds.Title);
        }
    }
}
