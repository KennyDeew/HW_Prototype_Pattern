using HW_Prototype_Pattern.SubClasses;

namespace HW_Prototype_Pattern
{
    /// <summary>
    /// Карамельно-шоколадный батончик
    /// </summary>
    public class CaramelChocolateSnack : ChocolateSnack, IMyCloneable<CaramelChocolateSnack>, ICloneable
    {
        /// <summary>
        /// Ссылка на карамель
        /// </summary>
        public Caramel Caramel { get; set; }

        /// <summary>
        /// параметр определяющий используется ли более дешевый аналог карамели
        /// </summary>
        public bool CaramelIsOptimized { get; set; }

        public CaramelChocolateSnack(Chocolate chocolate, Caramel caramel, bool chockolateIsOptimized, bool caramelIsOptimized) : base(chocolate, chockolateIsOptimized)
        {
            Caramel = caramel;
            CaramelIsOptimized = caramelIsOptimized;
        }

        public override CaramelChocolateSnack MyClone()
        {
            var caramelClone = Caramel.MyClone();
            var chocolateClone = Chocolate.MyClone();
            var snackClone = new CaramelChocolateSnack(chocolateClone, caramelClone, ChockolateIsOptimized, CaramelIsOptimized);
            return snackClone;
        }

        /// <summary>
        /// Замена карамели на более дешевый аналог
        /// </summary>
        public void OptimizeCaramel()
        {
            if (CaramelIsOptimized)
            {
                return;
            }
            Caramel.Description = "Cheap Caramel";
            CaramelIsOptimized = true;
        }

        public override object Clone()
        {
            return MyClone();
        }

        public override string ToString()
        {
            return $"Name - {Name}\n\rChocolate:{Chocolate.Description}, is optimized {ChockolateIsOptimized}\n\rCaramel:{Caramel.Description}, is optimized {CaramelIsOptimized}";
        }
    }
}
