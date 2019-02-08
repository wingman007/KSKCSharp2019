namespace Task10
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която приема за вход четирицифрено число във формат abcd  (например числото 2010) и след това извършва следните действия върху него:
            // -Пресмята сбора от цифрите на числото(за нашия пример 2 + 0 + 1 + 0 = 3).
            //- Разпечатва на конзолата цифрите в обратен ред: dcba(за нашия пример резултатът е 0102).
            //- Поставя последната цифра, на първо място: dabc(за нашия пример резултатът е 0201).
            //- Разменя мястото на втората и третата цифра: acbd(за нашия пример резултатът е 2100).

            int abcd = int.Parse(Console.ReadLine());
            int a = abcd / 1000;
            int b = (abcd / 100) % 10;
            int c = (abcd % 100) / 10;
            int d = abcd % 10;
            int sum = a + b + c + d;
            Console.WriteLine(sum);
            int reversed = 1000 * d + 100 * c + 10 * b + a;
            Console.WriteLine(reversed.ToString("D4"));

            int firstLastDigitChanged = 1000 * d + 100 * b + 10 * c + a;
            Console.WriteLine(firstLastDigitChanged.ToString("D4"));

            int secondThirdDigitChanged = 1000 * a + 100 * c + 10 * b + d;
            Console.WriteLine(secondThirdDigitChanged.ToString("D4"));

        }
    }
}
