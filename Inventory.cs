using System.Collections.Generic;

namespace RicksApp
{
    class Inventory
    {
        List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>
            {
                new Guitar("AA43982", 1235, new GuitarSpec(Builder.Fender, "Stratocastor", Type.Acoustic,  Wood.Alder, Wood.Alder)),
                new Guitar("AB25680", 1450, new GuitarSpec(Builder.Fender, "Stratocastor", Type.Acoustic,  Wood.Alder, Wood.Alder))
            };
        }

        public void AddGuitar(string serialNumber, double price, GuitarSpec spec)
        {
            var guitar = new Guitar(serialNumber, price, spec);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (var guitar in guitars)
            {
                if (guitar.SerialNumber == serialNumber)
                {
                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> SearchGuitar(GuitarSpec searchGuitar)
        {
            var matchingGuitar = new List<Guitar>();
            foreach (var guitar in guitars)
            {
                var builder = guitar.Spec.Builder;
                if(builder!=searchGuitar.Builder)
                    continue;
                var model = guitar.Spec.Model.ToLower();
                if (model != searchGuitar.Model.ToLower())
                    continue;
                var type = guitar.Spec.Type;
                if (type != searchGuitar.Type)
                    continue;
                var topWood = guitar.Spec.BackWood;
                if (topWood != searchGuitar.TopWood)
                    continue;
                var backWood = guitar.Spec.BackWood;
                if (backWood != searchGuitar.BackWood)
                    continue;
                matchingGuitar.Add(guitar);
            }
            return matchingGuitar;
        }
    }
}
