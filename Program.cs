using System;

namespace RicksApp
{
    class Program
    {
        static Inventory inventory = new Inventory();
        static void Main()
        {
            ImitateCatalog();
            var whatErinLikes = new GuitarSpec(Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder, StringCount.Six);
            var guitarList = inventory.SearchGuitar(whatErinLikes);
            if (guitarList.Count != 0)
            {
                Console.WriteLine("Erin, you might like this:");
                foreach (var guitar in guitarList)
                {
                    var message = $"We have a {guitar.Spec.Builder} {guitar.Spec.Model} {guitar.Spec.Type} guitar {Environment.NewLine}" +
                                  $"with {guitar.Spec.BackWood} back and sides, {guitar.Spec.TopWood} top {Environment.NewLine}" +
                                  $"You can have it for only ${guitar.Price}!";
                    Console.WriteLine(message);
                    Console.WriteLine(new string('-', 4));
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you");
            }
            Console.ReadKey();
        }

        private static void ImitateCatalog()
        {
               inventory.AddGuitar(new Guitar("AA43982", 1235, new GuitarSpec(Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder, StringCount.Six)));
               inventory.AddGuitar(new Guitar("AB25680", 1450, new GuitarSpec(Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder, StringCount.Six)));
        }
    }
}
