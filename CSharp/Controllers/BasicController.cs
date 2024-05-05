using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CSharp.Modules.Inheritance;
using CSharp.Modules.Inheritance.ConstructorInheritance;
using CSharp.Modules.MethodOverriding;
using CSharp.Modules;
using CSharp.Modules.DependencyInjection;
using CSharp.Modules.ExtensionMethod;
using CSharp.Modules.Polymorphism;
using CSharp.Modules.Encapsulation;

namespace CSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicController : ControllerBase
    {
        [HttpGet("PrintInConsole")]
        public string PrintInConsole()
        {
            Console.WriteLine("This method shows how to print in Console");
            Console.WriteLine(26);
            return "This method shows how to print in Console";
        }

        [HttpGet("simple-inheritance")]
        public void SimpleInheritance()
        {
            Child childInstance = new Child();
            childInstance.GreetChild();
            childInstance.SimpleInheritance();
        }

        [HttpGet("constructor-inheritance")]
        public void ConstructorInheritanceEndpoint()
        {
            ConstructorInheritance constructorInheritance = new ConstructorInheritance("Constructor Inheritance");
            constructorInheritance.ChildMethod();
            constructorInheritance.ParentMethod();
        }

        [HttpGet("multiple-inheritance")]
        public void MultipleInheritanceEndpoint()
        {
            Modules.MultipleInheritance.Child childClass = new Modules.MultipleInheritance.Child();
            childClass.FirstBaseClass();
            childClass.SecondBaseClass();
        }

        [HttpGet("method-override")]
        public void MethodOverrideEndpoint()
        {
            MethodOverriding methodOverriding = new MethodOverriding();
            methodOverriding.OverrideMethod();
        }

        [HttpGet("partial-class")]
        public void PartialClassEndpoint()
        {
            Partial partialClass = new Partial();
            partialClass.PartialClassOne();
            partialClass.PartialClassTwo();
            partialClass.PartialClassThree();
        }

        [HttpGet("dependency-injection")]
        public void DependencyInjectionEndpoint()
        {
            ILogging consoleLogger = new ConsoleLogger();
            ILogging fileLogger = new FileLogger();

            ClientLogger clientConsoleLogger = new ClientLogger(consoleLogger);
            ClientLogger clientFileLogger = new ClientLogger(fileLogger);

            clientConsoleLogger.LogMessage();
            clientFileLogger.LogMessage();
        }

        [HttpGet("extension-method")]
        public void ExtensionMethodsEndpoint()
        {
            Console.WriteLine("UPPERCASETOLOWERCASE".ConvertToLower());
        }

        [HttpGet("polymorphism")]
        public void PolymorphismEndpoint()
        {
            Polymorphism polymorphism = new Polymorphism();
            polymorphism.Sum(2, 3);
            polymorphism.Sum(2.3, 4.0);
        }

        [HttpGet("encapsulation")]
        public void EncapsulationEndpoint()
        {
            Encapsulation encapsulation = new Encapsulation();
            encapsulation.Name = "Zameer";
            encapsulation.Age = 20;
            encapsulation.DisplayDetails();

            encapsulation.Name = "Ahammad";
            encapsulation.Age = 101;
            encapsulation.DisplayDetails();
        }
    }
}
