namespace CSharp.Modules.Polymorphism
{
    public class Polymorphism
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine($"Sum of {a} and {b} : {a+b}");
        }

        public void Sum(double a, double b)
        {
            Console.WriteLine($"Sum of {a} and {b} : {a + b}");
        }
    }
}
