namespace CSharp.Modules.MethodOverriding
{
    public class MethodOverriding:Parent
    {
        public override void OverrideMethod()
        {
            base.OverrideMethod();
            Console.WriteLine("This line is executed in Overrided Method");
        }
    }
}
