namespace Task2
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата радиуса "r" на кръг и отпечатва неговия периметър и обиколка.

            Console.Write("Enter the radius of the circle:");
            double r = double.Parse(Console.ReadLine());
            double d = r * 2;
            double result = Math.PI * d;
            double area = Math.PI * r * r;
            Console.WriteLine("The perimeter is {0}.", result);
            Console.WriteLine($"The area is {area}");
        }
    }
}
