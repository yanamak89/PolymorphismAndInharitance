namespace InheritanceAndPolymorphism;

// Для класу Plane має бути визначена висота та кількість пасажирів. 

public class Plane : Vehicle
{
    private double height;
    private int passengers;


    public Plane(double latitude, double longitude, double price, int speed, int yearOfProduction, double height, int passengers) 
        : base(latitude, longitude, price, speed, yearOfProduction)
    {
        this.height = height;
        this.passengers = passengers;
    }
    
    public override void PrintInfo()
    {
        Console.WriteLine("Information about Plane -> ");
        base.PrintInfo(); // Викликаємо метод базового класу
        Console.WriteLine($"Height: {height} metres.");
        Console.WriteLine($"Passangers: {passengers}. \n-----------");
        
    }
}