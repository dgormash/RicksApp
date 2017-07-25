namespace RicksApp
{
    public class Guitar
    {
        public Guitar(string serialNumber, double price,  GuitarSpec spec)
        {
            SerialNumber = serialNumber;
            Price = price;
            Spec = spec;
            
        }

        public string SerialNumber { get; }

        public double Price { get; }

        public GuitarSpec Spec { get; }
    }
}