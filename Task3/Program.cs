using System;
using InheritanceAndPolymorphism;

class Program
{
    static void Main(string[] args)
    {
        Ship ship = new Ship(123.2, 222.4, 1000000.3, 150, 2023, 23, "Port of Mallorka");
        ship.PrintInfo();
        
        Car car = new Car(123.3349876, 7654.7654567, 45000.0, 260, 2017);
        car.PrintInfo();

        Plane plane = new Plane(45765.3456, 34566.5322222, 105500000, 900, 2004, 14000, 55);
        plane.PrintInfo();
    }
}