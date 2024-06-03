namespace InheritanceAndPolymorphism;

//У тілі класу створіть поля: координати та параметри суден (ціна, швидкість, рік випуску).
public class Vehicle
{
    // Поля для координат
    private double latitude; // Широта
    private double longitude; // Довгота
    
    // Поля для параметрів судна
    private double price;
    private int speed;
    private int yearOfProduction;
    
    // Конструктор класу
    public Vehicle(double latitude, double longitude, double price, int speed, int yearOfProduction)
    {
        this.latitude = latitude;
        this.longitude = longitude;
        this.price = price;
        this.speed = speed;
        this.yearOfProduction = yearOfProduction;
    }

    public virtual void PrintInfo()
    {
        
        Console.WriteLine($"Coordinates: {latitude}, {longitude}.");
        Console.WriteLine($"Price: {price} USD.");
        Console.WriteLine($"Speed: {speed} km/h.");
        Console.WriteLine($"Year of production: {yearOfProduction}.");
        
    }

}