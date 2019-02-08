namespace Task8
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която проверява дали дадена точка О (x, y) е вътре в окръжността К ((0,0), 5). Пояснение: точката (0,0) е център на окръжността, а радиусът й е 5.

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool O =Math.Sqrt( (x * x) + (y * y) )<= 5;
            Console.WriteLine(O);

        }
    }
}
