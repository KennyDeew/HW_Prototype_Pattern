namespace HW_Prototype_Pattern.SubClasses
{
    public class Nut : IMyCloneable<Nut>
    {
        public string Description { get; set; }

        public Nut(string description)
        {
            Description = description;
        }

        public Nut MyClone()
        {
            return new Nut(Description);
        }
    }
}
