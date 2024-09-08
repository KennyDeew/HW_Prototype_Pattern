using HW_Prototype_Pattern.SubClasses;
using Newtonsoft.Json;

namespace HW_Prototype_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var originalChocolate = new Chocolate("Milk Chokolate");
            var otiginalCaramel = new Caramel("Sweet Caramel");
            var originalNut = new Nut("Peanut");
            var originalSnack = new CaramelNutChocolateSnack(originalChocolate, otiginalCaramel, originalNut, chockolateIsOptimized: false, caramelIsOptimized: false);
            originalSnack.Name = "Snickers";

            var localSnack1 = originalSnack.MyClone();
            localSnack1.OptimizeChocolate();
            localSnack1.Name = "Sprint";

            var localSnack2 = originalSnack.MyClone();
            localSnack2.OptimizeCaramel();
            localSnack2.Name = "Step";

            //Демонстрация клонов
            Console.WriteLine("Prototype:");
            Console.WriteLine(originalSnack.ToString());

            Console.WriteLine($"\n\rCopy number 1:");
            Console.WriteLine(localSnack1.ToString());

            Console.WriteLine($"\n\rCopy number 2:");
            Console.WriteLine(localSnack2.ToString());
        }

        //private string DescribeObject()
    }
}
