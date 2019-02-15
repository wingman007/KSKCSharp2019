namespace Task5
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която чете от конзолата две цели числа (int) и отпечатва, колко числа има между тях, такива, че остатъкът им от деленето на 5 да е 0. 
              Пример: в интервала (17, 25) има 2 такива числа.*/


            Console.Write("Enter your first number:");
            int fn = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number(must be bigger than the first):");
            int sn = int.Parse(Console.ReadLine());
            int tn = (sn / 5) - (fn / 5);

            if (fn % 5 == 00) ;
            {

                tn++;
            }

            Console.WriteLine(tn);
        }
    }
}
