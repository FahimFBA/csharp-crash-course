using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeSpecialDish();


            ItalianChef italianchef = new ItalianChef();
            italianchef.MakeSpecialDish();






            Console.ReadLine();
        }
    }
}
