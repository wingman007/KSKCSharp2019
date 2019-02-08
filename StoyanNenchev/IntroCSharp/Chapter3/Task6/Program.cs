namespace Task6
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която за подадени от потребителя дължина и височина на правоъгълник, пресмята и отпечатва на конзолата неговия периметър и лице.
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double perimeter = 2 * a + 2 * b;
            double face = a * b;
            Console.WriteLine("Perimeter is " + perimeter);
            Console.WriteLine("Face is " + face);
        }
    }
}
