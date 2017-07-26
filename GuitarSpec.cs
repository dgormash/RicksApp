
namespace RicksApp
{
    public class GuitarSpec
    {
        public Builder Builder { get; }

        public string Model { get; }

        public Type Type { get; }

        public Wood BackWood { get; }

        public Wood TopWood { get; }

        public StringCount NumStrings { get; }

        public GuitarSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood, StringCount numStrings)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
            NumStrings = numStrings;
        }

        public bool CompareSpecWith(GuitarSpec spec)
        {
            if (Builder != spec.Builder)
                return false;
            if (Model != spec.Model)
                return false;
            if (Type != spec.Type)
                return false;
            if (TopWood != spec.TopWood)
                return false;
            if (BackWood != spec.BackWood)
                return false;
            if (NumStrings != spec.NumStrings)
                return false;
            return true;
        }
    }

}