namespace CSharp.Modules.Inheritance.ConstructorInheritance
{
    public class Parent
    {
        private readonly string _inheritanceType;
        public Parent(string inheritanceType)
        {
            _inheritanceType = inheritanceType;
        }

        public void ParentMethod()
        {
            Console.WriteLine($"This line is executed in Parent Class, example of {_inheritanceType}");
        }
    }
}
