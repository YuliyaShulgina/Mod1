using System;

namespace DZ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int asciiPos = 65;
            Random r = new Random();
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Исходный массив: ");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {

                arr[i] = r.Next(1, 26);

            }

            int CountOfEven = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
                if (arr[i] % 2 == 0) CountOfEven++;
            }

            int[] EvenArr = new int[CountOfEven];
            int[] OddArr = new int[n - CountOfEven];
            Console.WriteLine();
            int EvenIndex = 0, OddIndex = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    EvenArr[EvenIndex] = arr[i];
                    EvenIndex++;
                }
                else
                {
                    OddArr[OddIndex] = arr[i];
                    OddIndex++;
                }
            }

            Console.Write("Четные: ");
            for (int i = 0; i < CountOfEven; i++)
            {
                Console.Write("{0} ", EvenArr[i]);
            }

            Console.WriteLine();
            Console.Write("Нечетные: ");
            for (int i = 0; i < (n - CountOfEven); i++)
            {
                Console.Write("{0} ", OddArr[i]);
            }

            Console.WriteLine();
            Console.Write("Четные (буквы): ");
            for (int i = 0; i < CountOfEven; i++)
            {
                string asciiToLettersEven = char.ConvertFromUtf32(asciiPos + EvenArr[i]).ToLower();
                if ((asciiToLettersEven == "a") || (asciiToLettersEven == "e") || (asciiToLettersEven == "l") || (asciiToLettersEven == "d") || (asciiToLettersEven == "h") || (asciiToLettersEven == "j"))
                {
                    Console.Write("{0} ", asciiToLettersEven.ToUpper());
                }
                else
                {
                    Console.Write("{0} ", asciiToLettersEven);
                }
            }

            Console.WriteLine();
            Console.Write("Нечетные (буквы): ");
            for (int i = 0; i < (n - CountOfEven); i++)
            {
                string asciiToLettersOdd = char.ConvertFromUtf32(asciiPos + OddArr[i]).ToLower();
                if ((asciiToLettersOdd == "a") || (asciiToLettersOdd == "e") || (asciiToLettersOdd == "l") || (asciiToLettersOdd == "d") || (asciiToLettersOdd == "h") || (asciiToLettersOdd == "j"))
                {
                    Console.Write("{0} ", asciiToLettersOdd.ToUpper());
                }
                else
                {
                    Console.Write("{0} ", asciiToLettersOdd);
                }
            }

            Console.ReadLine();
        }
    }
}
