namespace Task9
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която проверява дали дадена точка О(x, y) е вътре в окръжността К((0, 0), 5) и едновременно с това извън правоъгълника((-1, 1), (5, 5).
            //Пояснение: правоъгълникът е зададен чрез координатите на горния си ляв и долния си десен ъгъл.

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool O =Math.Sqrt( (x * x) + (y * y)) <= 5;
            bool O1 = x < -1 || x > 5 || y < 1 || y > 5;
            bool result = O & O1;
            Console.WriteLine(result);

        }
    }
}
