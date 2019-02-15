namespace Task7
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете пет числа и отпечатва тяхната сума. При невалидно въведено число да се подкани потребителя да въведе друго число.

            Console.Write("Enter 5 numbers:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());

            double sum = a + b + c + d + f;
           
        }
    }
}
