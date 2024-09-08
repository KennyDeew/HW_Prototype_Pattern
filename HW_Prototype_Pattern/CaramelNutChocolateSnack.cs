using HW_Prototype_Pattern.SubClasses;

namespace HW_Prototype_Pattern
{
    /// <summary>
    /// Карамельно-шоколадный батончик с орешками
    /// </summary>
    public class CaramelNutChocolateSnack : CaramelChocolateSnack, IMyCloneable<CaramelNutChocolateSnack>, ICloneable
    {
        public Nut Nut { get; set; }

        public CaramelNutChocolateSnack(Chocolate chocolate, Caramel caramel, Nut nut, bool chockolateIsOptimized, bool caramelIsOptimized) : base(chocolate, caramel, chockolateIsOptimized, caramelIsOptimized)
        {
            Nut = nut;
        }

        public override CaramelNutChocolateSnack MyClone()
        {
            var caramelClone = Caramel.MyClone();
            var chocolateClone = Chocolate.MyClone();
            var nutClone = Nut.MyClone();
            var snackClone = new CaramelNutChocolateSnack(chocolateClone, caramelClone, nutClone, ChockolateIsOptimized, CaramelIsOptimized);
            return snackClone;
        }

        public override object Clone()
        {
            return MyClone();
        }

        public override string ToString()
        {
            return $"Name - {Name}\n\rChocolate: {Chocolate.Description}, is optimized {ChockolateIsOptimized}\n\rCaramel: {Caramel.Description}, is optimized {CaramelIsOptimized}\n\rNut: {Nut.Description}";
        }
    }
}
