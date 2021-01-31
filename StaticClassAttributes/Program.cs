using System;

namespace StaticClassAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday" , "Green Day" , 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir" , "Led Zeppelin" , 150);
            Console.WriteLine(kashmir.getSongCount());


            // Console.WriteLine(holiday.title);
            // Console.WriteLine(kashmir.title);
            // Console.WriteLine(Song.songCount); // static attribute
            // Console.WriteLine(Song.songCount); 
            // Console.WriteLine(Song.songCount); 
 





            Console.ReadLine();
        }
    }
}
