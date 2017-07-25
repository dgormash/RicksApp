using System;

namespace RicksApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory();
            var whatErinLikes = new GuitarSpec(Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder);
            var guitarList = inventory.SearchGuitar(whatErinLikes);
            if (guitarList != null)
            {
                foreach (var guitar in guitarList)
                {
                    Console.WriteLine("Erin, you might like this:");
                    Console.WriteLine(guitar.Spec.Builder);
                    Console.WriteLine(guitar.Spec.Model);
                    Console.WriteLine(guitar.Spec.Type + " guitar");
                    Console.WriteLine(guitar.Spec.TopWood);
                    Console.WriteLine(guitar.Spec.BackWood);
                    Console.WriteLine("Price:" + guitar.Price);
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you");
            }
            Console.ReadKey();
        }
    }
}
