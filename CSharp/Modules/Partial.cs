namespace CSharp.Modules
{
    public partial class Partial
    {
        public void PartialClassOne() => Console.WriteLine("this line is executed in the First Partial Class");
    }

    public partial class Partial
    {
        public void PartialClassTwo() => Console.WriteLine("this line is executed in the Second Partial Class");
    }
}
