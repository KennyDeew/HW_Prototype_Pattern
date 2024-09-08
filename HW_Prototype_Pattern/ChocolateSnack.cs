using HW_Prototype_Pattern.SubClasses;

namespace HW_Prototype_Pattern
{
    /// <summary>
    /// Шоколадный батончик
    /// </summary>
    public class ChocolateSnack : IMyCloneable<ChocolateSnack>, ICloneable
    {
        /// <summary>
        /// Наименование батончика
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ссылка на шоколад
        /// </summary>
        public Chocolate Chocolate { get; set; }

        /// <summary>
        /// параметр определяющий используется ли более дешевый аналог шоколада
        /// </summary>
        public bool ChockolateIsOptimized { get; set; }

        public ChocolateSnack(Chocolate chocolate, bool chockolateIsOptimized)
        {
            Chocolate = chocolate;
            ChockolateIsOptimized = chockolateIsOptimized;
        }

        public virtual ChocolateSnack MyClone()
        {
            var chocolateClone = Chocolate.MyClone();
            var snakeClone = new ChocolateSnack(chocolateClone, ChockolateIsOptimized);
            return snakeClone;
        }

        /// <summary>
        /// Замена шоколада на более дешевый аналог
        /// </summary>
        public void OptimizeChocolate()
        {
            if (ChockolateIsOptimized)
            {
                return;
            }
            Chocolate.Description = "Cheap Chockolate";
            ChockolateIsOptimized = true;
        }

        public virtual object Clone()
        {
            return MyClone();
        }

        public override string ToString()
        {
            return $"Name - {Name}\n\rChocolate:{Chocolate.Description}, is optimized {ChockolateIsOptimized}";
        }
    }
}
