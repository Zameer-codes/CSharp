namespace CSharp.Modules.Inheritance.ConstructorInheritance
{
    public class ConstructorInheritance:Parent
    {
        private readonly string _inheritanceType;
        public ConstructorInheritance(string InheritanceType):base(InheritanceType)
        {
            _inheritanceType = InheritanceType;
        }

        public void ChildMethod()
        {
            Console.WriteLine($"This line is executed in Child Method, example of {_inheritanceType}");
        }
    }
}
