using System.Collections.Generic;

namespace RicksApp
{
    class Inventory
    {
        List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();

        }

        public void AddGuitar(Guitar guitar)
        {
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
                if(guitar.Spec.CompareSpecWith(searchGuitar))
                matchingGuitar.Add(guitar);
            }
            return matchingGuitar;
        }
    }
}
