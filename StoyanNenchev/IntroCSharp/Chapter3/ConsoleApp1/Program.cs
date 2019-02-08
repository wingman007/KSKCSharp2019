
namespace Task1
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете израз, който да проверява дали дадено цяло число е четно или нечетно.

            int number = int.Parse(Console.ReadLine());
            bool Even = number % 2 == 0;
            Console.WriteLine(Even);
        }
    }
}
