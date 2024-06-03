namespace InheritanceAndPolymorphism;

// Для класу Ship – кількість пасажирів та порт приписки. 


public class Ship : Vehicle
{
    private int passengers;
    private string port;
    
    public Ship(double latitude, double longitude, double price, int speed, int yearOfProduction,int passangers, string port) 
        : base(latitude, longitude, price, speed, yearOfProduction)
    {
        this.passengers = passangers;
        this.port = port;
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Information about Ship -> ");
        base.PrintInfo();
        Console.WriteLine($"Port: {port}.");
        Console.WriteLine($"Passangers: {passengers}. \n-----------");
        
    }
}