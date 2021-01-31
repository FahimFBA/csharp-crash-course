using System;

namespace Inheritance
{
    class ItalianChef : Chef   // using inheritance
    {
       
          public void MakePasta()
          {
              Console.Write("The chef makes pasta");
          }

        
          public override void MakeSpecialDish() // overriding the method
            {
                Console.WriteLine("The chef makes chicken parms");
            }
        
    }
}
