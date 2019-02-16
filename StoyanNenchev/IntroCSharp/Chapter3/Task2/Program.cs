namespace Task2
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете булев израз, който да проверява дали дадено цяло число се дели на 5 и на 7 без остатък.

            int number = int.Parse(Console.ReadLine());
            bool Divisible = number % 35 == 0;
            Console.WriteLine(Divisible);
        }
    }
}
