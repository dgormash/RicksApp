
namespace RicksApp
{
    public class GuitarSpec : InstrumentSpec
    {
        public StringCount NumStrings { get; }

        public GuitarSpec(Builder builder, string model, Type type,  Wood backWood, Wood topWood, StringCount numString)
            :
                base(builder, model, type, backWood, topWood)
        {
            NumStrings = numString;
        }

        public override bool CompareSpecWith(InstrumentSpec spec)
        {
            if (!base.CompareSpecWith(spec))
            {
                return false;
            }
            if (!(spec is GuitarSpec))
            {
                return false;
            }
            var comparedSpec = (GuitarSpec) spec;
            if (NumStrings != comparedSpec.NumStrings)
            {
                return false;
            }

            return true;

        }

        
            
        
    }

}