namespace Task6
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете две числа от конзолата и отпечатва по-голямото от тях. Решете задачата без да използвате условни конструкции.

            Console.Write("Write two numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Greater: {0}", (a + b + Math.Abs(a - b)) / 2);
            Console.WriteLine("Smaller: {0}", (a + b - Math.Abs(a - b)) / 2);

        }
    }
}
