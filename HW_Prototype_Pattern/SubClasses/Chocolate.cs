namespace HW_Prototype_Pattern.SubClasses
{
    public class Chocolate : IMyCloneable<Chocolate>
    {
        public string Description { get; set; }

        public Chocolate(string description)
        {
            Description = description;
        }

        public Chocolate MyClone()
        {
            return new Chocolate(Description);
        }
    }
}
