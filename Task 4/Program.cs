using System;
using System.Threading.Channels;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість елементів масиву:\t");

        int elementsCount = int.Parse(Console.ReadLine());

        int[] numbers = new int[elementsCount];

        int positiveNumber = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"\nВведіть елемент масиву під індексом {i}:\t ");
            numbers[i] = int.Parse(Console.ReadLine());
        }


        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                positiveNumber += numbers[i];
            }
        }
        Console.WriteLine($"Сума додатніх чисел масиву: {positiveNumber}");
        Console.ReadLine();
    }   
}
