using CSharp_Oop;

Cars cars = new();
Console.WriteLine("Enter the brand of car:");
cars.Brand = Console.ReadLine();
Console.WriteLine("Enter the name of car:");
cars.Name = Console.ReadLine();
cars.Wheel = 4;
Console.WriteLine("-------------------------");
Console.WriteLine("The brand of car is: {0}", cars.Brand);
Console.WriteLine("The name of car is: {0}", cars.Name);
Console.WriteLine("Number of Wheel: {0}", cars.Wheel);