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

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                Console.WriteLine($"\nВсі парні числа даного масиву: {numbers[i]}");
            }
        }

        Console.ReadLine();
    }
}