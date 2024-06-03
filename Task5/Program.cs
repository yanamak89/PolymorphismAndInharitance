using Task5;

class Program
{
    static void Main(string[] args)
    {
        Printer print = new Printer();
        // Викликаємо метод друкування
        print.Print("This is a regular text to print.");

        ColoredPrinter coloredPrinter = new ColoredPrinter();
        coloredPrinter.Print("This is a dark cyan text to print.", ConsoleColor.DarkCyan);
        coloredPrinter.Print("This is a dark red text to print.", ConsoleColor.DarkRed);
        coloredPrinter.Print("This is a magenta text to print.", ConsoleColor.Magenta);
    }
}