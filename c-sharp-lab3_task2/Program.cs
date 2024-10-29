namespace c_sharp_lab3_task2;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];
        int i = 0;

        while (i < 10)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine()!;
            try
            {
                numbers[i] = int.Parse(input);
                ++i;
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a number!");
            }
        }
        
        int max = int.MinValue;
        int min = int.MaxValue;
        int sum = 0;

        for (int j = numbers.Length - 1; j >= 0; j--)
        {
            Console.Write($"{numbers[j]} ");
            
            sum += numbers[j];
            if(numbers[j] > max) max = numbers[j];
            if(numbers[j] < min) min = numbers[j];
        }
        Console.WriteLine();
        
        double average = (double)sum / numbers.Length;
        
        Console.WriteLine($"Max = {max}, Min = {min}, Average = {average}");

        foreach (int num in numbers)
        {
            if(num > average) Console.Write($"{num} ");
        }
        Console.WriteLine();
        
        Console.WriteLine("Чи бажаєте ви відсортувати список? [y/n]");
        if (Console.ReadLine() == "y")
        {
            Array.Sort(numbers);
            foreach (var j in numbers)
            {
                Console.Write($"{j} ");
            }
        }
    }
}