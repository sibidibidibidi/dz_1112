using System;

namespace InterfaceHW
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 10, 25, 27, 12 };
            ICalc calculator = new Array(numbers);

            Console.WriteLine("Values less than 10: " + calculator.countlessthan(10));
            Console.WriteLine("Values greater than 10: " + calculator.countgreaterthan(10));

            Console.ReadKey();
        }
    }
}

