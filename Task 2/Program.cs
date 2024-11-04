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
         bool isPalindrome = IsPalindrome(numbers);

        if (isPalindrome)
        {
            Console.WriteLine("Масив є паліндромом.");
        }
        else
        {
            Console.WriteLine("Масив не є паліндромом.");
        }
        Console.ReadLine();
    }

    static bool IsPalindrome(int[] numbers)
    {
        int length = numbers.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (numbers[i] != numbers[length - i - 1])
            {
                return false;
            }
        }
        return true;

        Console.ReadLine();
    }
}
    
