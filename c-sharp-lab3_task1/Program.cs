namespace c_sharp_lab3_task1;

class Program
{
    static void Main()
    {
        bool keepPlaying = true;

        while (keepPlaying)
        {
            var number = Random.Shared.Next(1, 11); // number Є [1, 10]

            while (true)
            {
                Console.Write("Вгадайте число або 'e' для виходу: ");
                string input = Console.ReadLine()!;

                if (input == "e")
                {
                    break;
                }

                int guess;

                try
                {
                    guess = int.Parse(input);
                }
                catch (Exception e)
                {
                    if (e is FormatException || e is OverflowException)
                        continue;

                    throw;
                }

                if (guess == number)
                {
                    Console.WriteLine("Ви вгадали число!");
                    break;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Ваше число завелике!");
                }
                else
                {
                    Console.WriteLine("Ваше число замале!");
                }
            }

            string input2;
            do
            {
                Console.Write("Бажаєте зіграти знову? [y/n] ");
                input2 = Console.ReadLine()!;
            } while (input2 != "n" && input2 != "y");

            keepPlaying = input2 == "y";
        }
    }
}