class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість елементів масиву:\t");

        int elementsCount = int.Parse(Console.ReadLine());

        int[] numbers = new int[elementsCount];

        int product = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"\nВведіть елемент масиву під індексом {i}:\t ");
            numbers[i] = int.Parse(Console.ReadLine());
        }


        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0)
            {
                product *= numbers[i];
            }
        }
        Console.WriteLine($"Добуток від'ємних чисел дорвінює: {product}");
        Console.ReadLine();
    }
}
