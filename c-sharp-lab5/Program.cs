namespace c_sharp_lab5;

class Program
{
    static void Main(string[] args)
    {
        string path = AskForExistingFilePath();
        
        Console.WriteLine("Вміст файлу:");
        PrintFileContents(path);

        Console.WriteLine();
        
        if (AskQuestion("Бажаєте записати щось в цей файл? [y/n]:", ["y", "n"]) == "n")
        {
            return;
        }

        string input = AskQuestion("Перезаписати(1) або додати(2)?", ["1", "2"]);

        Console.WriteLine("Введіть дані для запису:");
        string line = Console.ReadLine()! + "\n";

        try
        {
            switch (input)
            {
                case "1":
                    File.WriteAllText(path, line);
                    break;
                case "2":
                    File.AppendAllText(path, line);
                    break;
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Помилка I/O: не вдалося записати в файл");
            Console.WriteLine(e.Message);
        }
    }

    /// <summary>
    /// print file contents in utf32 with error handling
    /// </summary>
    public static void PrintFileContents(string filePath)
    {
        try
        {
            using (var sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    Console.Write(Char.ConvertFromUtf32(sr.Read()));
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Помилка I/O: не вдалося прочитати файл");
            Console.WriteLine(e.Message);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Файл використовує кодування відмінне від utf32!");
        }
    }

    /// <summary>
    /// ask the user for a file path. if file doesn't exist prompt to create new one, if not, repeat
    /// </summary>
    /// <returns>a path to existing file</returns>
    /// <returns></returns>
    public static string AskForExistingFilePath()
    {
        string input;
        bool exit = false;
        do
        {
            Console.Write("Вкажіть шлях до файлу: ");
            input = Console.ReadLine()!;

            if (File.Exists(input))
            {
                exit = true;
            }
            else if (AskQuestion("Файл не існує. Чи бажаєте створити новий файл? [y/n]", ["y", "n"]) == "y")
            {
                File.Create(input).Close();
                exit = true;
            }
        } while (!exit);

        return input;
    }

    /// <summary>
    /// ask the user a question until one of the options is chosen
    /// </summary>
    /// <param name="prompt">the question</param>
    /// <param name="options">options, like 'yes' or 'n'</param>
    /// <returns>the option selected</returns>
    public static string AskQuestion(string prompt, string[] options)
    {
        string input;
        do
        {
            Console.Write($"{prompt} ");
            input = Console.ReadLine()!;
        } while (!options.Contains(input));

        return input;
    }
}