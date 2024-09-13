using Tyuiu.KurbanovFA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.KurbanovFA.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));

            Console.ReadKey();
        }
    }
}
