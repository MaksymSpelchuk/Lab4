using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість елементів масиву:\t");

        int elementsCount = int.Parse(Console.ReadLine());

        int[] numbers = new int[elementsCount];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"\nВведіть елемент масиву під індексом {i}:\t ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int minValue = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
            }
        }
        Console.WriteLine("Найменший індекс масиву: " + minValue);
        Console.ReadLine();
    }
}