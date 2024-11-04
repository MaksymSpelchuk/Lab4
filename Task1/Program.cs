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
        numbers.Average();
        Console.WriteLine("\nСереднє арифметичне дорівнює " + numbers.Average());

        Console.ReadLine();
    }
}
