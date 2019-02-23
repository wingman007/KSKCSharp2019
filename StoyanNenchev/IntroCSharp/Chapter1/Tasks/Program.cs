using System;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добър Ден!"); 
            Console.WriteLine("First Name:");
            Console.Write("");
            Console.ReadLine();
            Console.WriteLine("Last Name:");
            Console.Write("");
            Console.ReadLine();
            Console.WriteLine("1\n101\n1001");
            DateTime localDate = DateTime.Now;
            Console.WriteLine(localDate);
            Console.WriteLine("Enter the Number:");
            double first = double.Parse(Console.ReadLine());
            double result = Math.Sqrt(first);
            Console.WriteLine(result);
            Console.WriteLine("Cycle of the numebr 2 to a 100");
            for (int i = 2; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.Write(" " + i + " ");
                else
                    Console.Write("-" + i);
            }
            Console.WriteLine("\nEnter your age");
            int age = int.Parse(Console.ReadLine());
            DateTime ageNow = new DateTime(age, 01, 31);
            ageNow = ageNow.AddYears(10);
            Console.WriteLine(ageNow.Year);
        }
    }
}


