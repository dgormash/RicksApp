namespace RicksApp
{
    public abstract class Instrument
    {
        public string SerialNumber { get; }

        public double Price { get; set; }

        public InstrumentSpec Spec { get; }

        protected Instrument(string serialNumber, double price, InstrumentSpec spec)
        {
            SerialNumber = serialNumber;
            Price = price;
            Spec = spec;
        }
    }
}