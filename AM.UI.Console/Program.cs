// See https://aka.ms/new-console-template for more information
//using System.Numerics;

using AM.Core.Domain;
//TP1. Question 7
Console.WriteLine("Hello, World!");
Plane plane= new Plane();
plane.Capacity = 100;
plane.ManufactureDate = new DateTime(2000,1,1);
plane.MyPlaneType = PlaneType.BOING;

//TP1. Question 8
Plane plane2 = new Plane(PlaneType.BOING, 100, new DateTime(2000, 1, 1));

//TP1 Question 9 (initialiseur d'objet)
Plane plane3 = new Plane()
{
    Capacity= 100,
    ManufactureDate= new DateTime(2000, 1, 1),
    MyPlaneType= PlaneType.BOING
};

Passenger passenger = new Passenger();
passenger.BirthDate = new DateTime(1990, 5, 1);
//passenger.GetAge1();
Console.WriteLine(passenger.Age);

int age = 0;
Passenger passenger1 = new Passenger();
passenger.GetAge2(new DateTime(1990, 5, 1), ref age);
Console.WriteLine(age);
