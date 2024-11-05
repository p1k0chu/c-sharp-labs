namespace c_sharp_lab4;

class Program
{
    static void Main()
    {
        int[] array = new int[10];
        Console.WriteLine($"Введіть {array.Length} чисел: ");
        FillIntArrayWithUserInput(array, 0, array.Length - 1);
        
        // print all elements in reversed order
        for(int i = array.Length - 1; i >= 0; --i)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();

        int min = ArrayHelper.Min(array);
        int max = ArrayHelper.Max(array);
        
        Console.WriteLine($"Сума чисел: {ArrayHelper.Sum(array)}");
        Console.WriteLine($"Середнє значення: {ArrayHelper.Average(array)}");
        Console.WriteLine($"Максимальне значення: {max}");
        Console.WriteLine($"Мінімальне значення: {min}");
        Console.WriteLine($"Кількість чисел більших за середнє значення: {ArrayHelper.CountGreaterThanAverage(array)}");

        Console.WriteLine();
        MathHelper.Demo(array[0], array[1]);
        Console.WriteLine();
        
        ArrayHelper.BubbleSort(array);
        
        Console.WriteLine($"Медіана: {ArrayHelper.Median(array)}");
        Console.Write("Відсортований масив: ");
        foreach (int num in array)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine($"\nРізниця між максимальним та мінімальним значенням: {max - min}");
        
        
    }

    /** fill array with user input, parsed as Int32
     * <example>
     * <code>
     * int N = ...; // any integer
     * int[] array = new int[N];
     * FillIntArrayWithUserInput(array, 0, N - 1)
     * </code>
     * </example>
     * <param name="array">array to fill</param>
     * <param name="start">start index</param>
     * <param name="end">end index (inclusive)</param>
     */
    static void FillIntArrayWithUserInput(int[] array, int start, int end)
    {
        int i = start;
        while (i <= end)
        {
            Console.WriteLine($"Число №{i + 1}: ");
            if (Int32.TryParse(Console.ReadLine(), out int parsedInt))
            {
                array[i++] = parsedInt;
            }
        }
    }
}