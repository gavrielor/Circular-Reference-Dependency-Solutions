using CircularReferenceDependency.Models;

namespace CircularReferenceDependency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            System.Console.WriteLine("Running with Action:");
            a.RunWithAction();

            System.Console.WriteLine("------------------------");

            System.Console.WriteLine("Running with Interface:");
            a.RunWithInterface();
        }
    }
}
