using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата поредица от цели числа и отпечатва най-малкото и най-голямото от тях.


            do
            {
                Console.Write("Please enter a positive number:");
                int n = int.Parse(Console.ReadLine());

            } while (n < 1);


            int smallest = int.MinValue;
            int biggest = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (smallest > n)
                {
                    smallest = n;
                }
                if (biggest < n)
                {
                    biggest = n;
                }


            }
            Console.WriteLine(smallest);
            Console.WriteLine(biggest);
        }

    }
}
