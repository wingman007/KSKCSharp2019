namespace Task1
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата три числа от тип int и отпечатва тяхната сума.

            Console.WriteLine("Please enter three numbers:");
            int number = Int32.Parse(Console.ReadLine());
            int number2 = Int32.Parse(Console.ReadLine());
            int number3 = Int32.Parse(Console.ReadLine());

            int sum = number + number2 + number3;

            Console.WriteLine("The sum of your numbers is {0}.", sum);
        }
    }
}
