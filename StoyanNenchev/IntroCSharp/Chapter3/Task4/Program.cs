namespace Task4

{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете израз, който да проверява дали третия бит на дадено число е 1 или 0.
            int number = int.Parse(Console.ReadLine());
            int number1 = 3;
            int number2 = 1 << number1;
            int result = number & number2;
            bool finalresult = result > 0;
            Console.WriteLine(finalresult);
        }
}
}
