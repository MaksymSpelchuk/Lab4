using System;

class Program
{
    static void Main()
    {
        int[,] myArray = new int[4, 4];

        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                Console.WriteLine($"Введіть елемент масиву {i} {j} \t");
                myArray[i, j] = int.Parse(Console.ReadLine());

            }
        }
        Console.WriteLine();

        for (int i = 0;i < myArray.GetLength(0); i++)
        {
            for(int j = 0;  j < myArray.GetLength(1); j++)
            {
                Console.Write(myArray[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int sum = myArray[0, 0] + myArray[1, 1] + myArray[2, 2] + myArray[3, 3];
        Console.WriteLine("Сума по головній діагоналі дорівнює: " + sum);
        Console.ReadLine();


    }
}