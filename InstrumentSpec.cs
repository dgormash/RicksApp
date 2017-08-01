namespace RicksApp
{
    public abstract class InstrumentSpec
    {
        public Builder Builder { get; }

        public string Model { get; }

        public Type Type { get; }

        public Wood BackWood { get; }

        public Wood TopWood { get; }


        protected InstrumentSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
        }

        public virtual bool CompareSpecWith(InstrumentSpec spec)
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
            return true;
        }
    }
}
