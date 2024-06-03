namespace InheritanceAndPolymorphism;

public class Car :Vehicle
{
    public Car(double latitude, double longitude, double price, int speed, int yearOfProduction) : base(latitude, longitude, price, speed, yearOfProduction)
    {
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Information about Car -> ");
        base.PrintInfo();
        Console.WriteLine("-----------");

        
    }
}