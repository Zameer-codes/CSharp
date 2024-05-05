namespace CSharp.Modules.MultipleInheritance
{
    public class Child:ParentOne, IParentTwo
    {
        public void SecondBaseClass()
        {
            Console.WriteLine("This line is executed by Second Base Class");
        }
    }
}
