
namespace HW_Prototype_Pattern
{
    public interface IMyCloneable<TClass> where TClass : class
    {
        TClass MyClone();
    }
}
