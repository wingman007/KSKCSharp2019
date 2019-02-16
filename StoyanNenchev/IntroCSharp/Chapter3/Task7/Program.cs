namespace Task7
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Силата на гравитационното поле на Луната е приблизително 17% от това на Земята. Напишете програма, която да изчислява тежестта на човек на Луната, по дадената тежест на Земята.

            double weightearth = double.Parse(Console.ReadLine());
            double weightmoon = weightearth * 0.17;
            Console.WriteLine(weightmoon);
        }
    }
}
