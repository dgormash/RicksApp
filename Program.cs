using System;

namespace RicksApp
{
    class Program
    {
        static readonly Inventory inventory = new Inventory();
        static void Main()
        {
            ImitateCatalog();
            var whatErinLikes = new GuitarSpec(Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder, StringCount.Six);
            var guitarList = inventory.SearchInstrument(whatErinLikes);
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

            var whatSimonLikes = new MandolinSpec(Builder.Olson, "Rosario", Type.Acoustic,Wood.Cedare, Wood.IndianRosewood, MandolinStyle.F);
            var mandolinList = inventory.SearchInstrument(whatSimonLikes);
            Console.WriteLine("Simon, you might like this:");
            if (mandolinList.Count != 0)
            {
                foreach (var mandolin in mandolinList)
                {
                    var message =
                        $"We have a {mandolin.Spec.Builder} {mandolin.Spec.Model} {mandolin.Spec.Type} mandolin {Environment.NewLine}" +
                        $"with {mandolin.Spec.BackWood} back and sides, {mandolin.Spec.TopWood} top {Environment.NewLine}" +
                        $"You can have it for only ${mandolin.Price}!";
                    Console.WriteLine(message);
                    Console.WriteLine(new string('-', 4));
                }
            }
            else
            {
                Console.WriteLine("Sorry, Simon, we have nothing for you");
            }

            Console.ReadKey();
        }

        private static void ImitateCatalog()
        {
               inventory.AddInstrument(new Guitar("AA43982", 1235, new GuitarSpec(Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder, StringCount.Six)));
               inventory.AddInstrument(new Guitar("AB25680", 1450, new GuitarSpec(Builder.Fender, "Stratocastor", Type.Electric, Wood.Alder, Wood.Alder, StringCount.Six)));
               inventory.AddInstrument(new Mandolin("GT568SD", 145.45, new MandolinSpec(Builder.Olson, "Rosario", Type.Acoustic, Wood.Cedare, Wood.IndianRosewood, MandolinStyle.F)));
        }
    }
}
