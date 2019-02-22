namespace Task1
{
    using System;
    class Program
    {
        static void Main()
        {
            //Напишете програма, която отпечатва на конзолата числата от 1 до N. Числото N трябва да се чете от стандартния вход.


            int n = 0;
            do
            {
                Console.Write("Please enter a positive number:");
                n = int.Parse(Console.ReadLine());

            } while (n < 1);


            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
