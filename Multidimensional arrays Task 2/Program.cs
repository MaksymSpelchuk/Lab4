using System;


class Program
{
    static void Main()
    {
        int[,] myArrays = new int[4, 4];
        for (int i = 0; i < myArrays.GetLength(0); i++)
        {
            for (int j = 0; j < myArrays.GetLength(1); j++)
            {
                Console.WriteLine($"Введіть улумент масиву під індексом {i} {j} \t");
                myArrays[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();

        for (int i = 0;i < myArrays.GetLength(0); i++)
        {
            for(int j = 0;  j < myArrays.GetLength(1); j++)
            {
                Console.WriteLine(myArrays [i, j] + "+\t" );
            }
        }



        Console.ReadLine();
    }   
}
