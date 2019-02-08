namespace Task5
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете израз, който изчислява площта на трапец по дадени a, b и h.
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double result = (a + b) / 2 * h;
            Console.WriteLine(result);
        }
    }
}
