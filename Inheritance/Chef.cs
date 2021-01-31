using System;

namespace Inheritance
{
    class Chef
    {
       
            public void MakeChicken()
            {
                Console.WriteLine("The chef makes chicken");
            }

            public void MakeSalad()
            {
                Console.WriteLine("The chef makes salad");
            }

            public virtual void MakeSpecialDish()
            {
                Console.WriteLine("The chef makes bbq ribs");
            }

            
        
    }
}
