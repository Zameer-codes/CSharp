namespace CSharp.Modules.Encapsulation
{
    public class Encapsulation
    {
        private string name;
        private int age;
        public string Name { get { return name; } set { name = value; } }

        public int Age { get { return age; } 
            set
            {
                if (value >= 0 && value < 100) age = value;
                else age = 0;
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"User name is {Name} and age is {Age}");
        }
    }
}
