namespace c_sharp_lab2;

class Program
{
    public static void Main()
    {
        while (true) {
            Console.Write("Введіть оператор (+, -, /, *) або 0 для виходу: ");
            string operation = Console.ReadLine()!;

            if (operation == "0") break;
            
            Console.Write("Введіть перше число: ");
            string? line = Console.ReadLine();
            double num1 = Convert.ToDouble(line);

            Console.Write("Введіть друге число: ");
            line = Console.ReadLine();
            double num2 = Convert.ToDouble(line);

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Сума: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Різниця: {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Добуток: {num1 * num2}");
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Частка: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Помилка: ділення на нуль неможливе!");
                    }

                    break;
                default:
                    Console.WriteLine(">:(");
                    break;
            }
        }
    }
}