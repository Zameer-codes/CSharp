namespace CSharp.Modules.MethodOverriding
{
    public class Parent
    {
        public virtual void OverrideMethod()
        {
            Console.WriteLine("This line is executed in Original method");
        }
    }
}
