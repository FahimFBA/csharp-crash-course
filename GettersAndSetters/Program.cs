using System;

namespace GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Movie avengers = new Movie("The Avengers" , "Joss Whedon" , "PG-13");
            Movie shrek = new Movie("Shrek" , "Adam Adamson" , "PG");
            // G, PG, PG-13, R, NR : Movie ratings

            shrek.Rating = "Cat";

            Console.WriteLine(shrek.Rating);

           

            Console.WriteLine(avengers.Rating);
            Console.ReadLine();
        }
    }
}
