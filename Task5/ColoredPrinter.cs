namespace Task5;

public class ColoredPrinter : Printer
{
    // Метод друкування змісту рядка у консолі, де колір може бути змінений
    public void Print(string value, ConsoleColor color)
    {
        Console.ForegroundColor = color; // Змінюємо колір тексту
        Console.WriteLine(value); // Виводимо рядок у зазначеному кольорі
        Console.ResetColor(); // Скидаємо колір тексту на стандартний
    }
}