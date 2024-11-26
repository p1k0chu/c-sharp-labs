namespace c_sharp_lab6;

public class Book(string name, string author, int yearOfRelease, int pagesAmount)
{
    public string Name { get; } = name;
    public string Author { get; } = author;
    public int YearOfRelease { get; } = yearOfRelease;
    public int PagesAmount { get; } = pagesAmount;

    public override string ToString()
    {
        return $"Назва: \"{Name}\", Автор: \"{Author}\", Рік видання: {YearOfRelease}, Кількість сторінок: {PagesAmount}";
    }

    /// <summary>
    /// Чи книжка сучасна.
    /// <c>true</c> якщо видана після 2000 року включно, інакше <c>false</c>
    /// </summary>
    public bool IsModern()
    {
        return YearOfRelease >= 2000;
    }

    /// <summary>
    /// Чи книжка велика.
    /// <c>true</c> якщо має більше ніж 300 сторінок включно, інакше <c>false</c>
    /// </summary>
    public bool IsBig()
    {
        return PagesAmount >= 300;
    }
}