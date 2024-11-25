namespace c_sharp_lab6;

public class Student(string firstName, string lastName, int age, double gpa)
{
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
    public int Age { get; } = age;
    public double Gpa { get; } = gpa;

    public override string ToString()
    {
        return $"Ім'я: {FirstName} {LastName}, Вік: {Age}, Середній бал: {Gpa}";
    }

    /// <summary>
    /// Чи студент відмінник.
    /// <c>true</c> якщо середній бал >= 90, інакше <c>false</c>
    /// </summary>
    public bool IsExcellent()
    {
        return Gpa >= 90;
    }
}