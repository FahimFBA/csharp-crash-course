using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            // book1.title = "Harry Potter";
            // book1.author = "JK Rowling";
            // book1.pages = 400;

            Book book2 = new Book("Lord Of the Rings", "Tolkein", 700);
            // book2.title = "Lord Of the Rings";
            // book2.author = "Tolkein";
            // book2.pages = 700; 

            book2.title = "The Hobbit"; // Updating the value of book2.title

            Console.WriteLine(book2.title);



            Console.ReadLine();
        }
    }
}
