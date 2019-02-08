namespace Task3
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете израз, който да проверява дали дадено цяло число съдържа 7 за трета цифра (отдясно на ляво).

            int number = int.Parse(Console.ReadLine());
            int number1 = number / 100;
            int number2 = Math.Abs(number1 % 10);
            bool number3 = number2 == 7;
            Console.WriteLine(number3);
        }
    }
}
