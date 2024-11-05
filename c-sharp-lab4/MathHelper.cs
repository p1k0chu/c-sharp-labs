namespace c_sharp_lab4;

public class MathHelper
{
    public static void Demo(int a, int b)
    {
        Console.WriteLine($"Add(a, b) = {Add(a, b)}");
        Console.WriteLine($"Multiply(a, b) = {Multiply(a, b)}");
        Console.WriteLine($"Divide(a, b) = {Divide(a, b)}");
        Console.WriteLine($"Subtract(a, b) = {Subtract(a, b)}");
    }
    
    /// add two integers
    static int Add(int a, int b)
    {
        return a + b;
    }

    /// multiply two integers
    static int Multiply(int a, int b)
    {
        return a * b;
    }

    /// divide a by b
    static double Divide(int a, int b)
    {
        return (double)a / b;
    }
    
    /// subtract b from a
    static int Subtract(int a, int b)
    {
        return a - b;
    }
}