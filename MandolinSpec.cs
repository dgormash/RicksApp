namespace RicksApp
{
    public class MandolinSpec:InstrumentSpec
    {
        public MandolinSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood, MandolinStyle style) : base(builder, model, type, backWood, topWood)
        {
            Style = style;
        }

        MandolinStyle Style { get; }

        public override bool CompareSpecWith(InstrumentSpec spec)
        {
            if (!base.CompareSpecWith(spec))
            {
                return false;
            }
            if (!(spec is MandolinSpec))
            {
                return false;
            }
            var comparedSpec = (MandolinSpec)spec;
            if (Style != comparedSpec.Style)
            {
                return false;
            }
            return true;
        }
    }
}