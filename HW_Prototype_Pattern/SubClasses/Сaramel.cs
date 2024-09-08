namespace HW_Prototype_Pattern.SubClasses
{
    public class Caramel : IMyCloneable<Caramel>
    {
        public string Description { get; set; }

        public Caramel(string description)
        {
            Description = description;
        }

        public Caramel MyClone()
        {
            return new Caramel(Description);
        }
    }
}
