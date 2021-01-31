using System;
// ReSharper disable AssignNullToNotNullAttribute

namespace Kustova_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (var i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите элемент {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int min = array[0], minIndex = 0;
            int max = array[0], maxIndex = 0;
            
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }

            int delta = Math.Abs(maxIndex - minIndex);
            Console.WriteLine($"Разница индексов: {delta}");
            Console.ReadKey();
        }
    }
}