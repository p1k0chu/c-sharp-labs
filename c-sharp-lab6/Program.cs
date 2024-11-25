namespace c_sharp_lab6;

public class Program
{
    public static void Main()
    {
        Part1();
        Console.WriteLine();
        Part2();
    }

    public static void Part1()
    {
        var rng = new Random(DateTime.Now.Millisecond);

        var students = new[]
        {
            new Student("Ivan", "Ivanov", rng.Next(16, 40), rng.Next(70, 99) + rng.NextDouble()),
            new Student("John", "Doe", rng.Next(16, 40), rng.Next(70, 99) + rng.NextDouble()),
            new Student("Bruce", "Wayne", rng.Next(16, 40), rng.Next(70, 99) + rng.NextDouble())
        };
        
        Console.WriteLine("Учні: ");
        foreach(var i in students)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine("\nВідмінники: ");
        foreach(var i in students)
        {
            if(i.IsExcellent()) Console.WriteLine(i);
        }
    }
    
    public static void Part2()
    {
        var books = new[]
        {
            new Book("Harry Potter and the Philosopher's Stone", "J. K. Rowling", 1997, 223),
            new Book("Harry Potter and the Prisoner of Azkaban", "J. K. Rowling", 1999, 317),
            new Book("Harry Potter and the Order of the Phoenix", "J. K. Rowling", 2003, 766),
            new Book("Harry Potter and the Deathly Hallows", "J. K. Rowling", 2007, 607),
        };
        
        Console.WriteLine("Книжки:");
        
        foreach(var i in books)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine("\nСучасні книги: ");
        foreach(var i in books)
        {
            if(i.IsModern()) Console.WriteLine(i);
        }
        
        Console.WriteLine("\nВеликі книжки: ");
        foreach(var i in books)
        {
            if(i.IsBig()) Console.WriteLine(i);
        }
    }
}