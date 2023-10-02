using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string vehicleType;
            string vehicleBrand;
            string numberOfVeichles;
            string userCommand;

            Console.WriteLine("Hi there. Please enter your name: ");
            userName = Console.ReadLine();

            Console.WriteLine($"Hi there {userName}, please enter your vehicle interest (Car or Bus).");
            vehicleType = Console.ReadLine();


            Car car = new Car();
            Bus bus = new Bus();

            if (vehicleType.ToLower() == "car")
            {
                Console.WriteLine("Enter number of cars you want to enter: ");
                numberOfVeichles = Console.ReadLine();
                if(int.Parse(numberOfVeichles) < 0)
                {
                    Console.WriteLine("Please enter number of vehicles higher than 0");
                }
                else
                {
                    for (int i = 0; i < int.Parse(numberOfVeichles); i++)
                    {
                        Console.WriteLine($"Car{i + 1} - Enter what car type is this car (SUV, Sedan, Hatchback, Roadster, Coupe) is: ");
                        car.CarType = Console.ReadLine();
                        Console.WriteLine($"Car{i + 1} - Enter Top Speed of your car:");
                        car.TopSpeed = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Car{i + 1} - Enter what brand this car is(Audi, Mercedes, Hammer, Peugeot, Aston Martin): ");
                        vehicleBrand = Console.ReadLine();

                        car.AddCar(car, vehicleBrand);

                        Console.WriteLine($"\n\nEnter drive if you want for car {vehicleBrand} to start driving write 'drive' or write 'stop' to stop driving: ");
                        userCommand = Console.ReadLine();
                        if(userCommand.ToLower() == "drive")
                        {
                            car.Drive();
                        }
                        else if(userCommand.ToLower() == "stop")
                        {
                            car.Stop();
                        }
                        
                    }
                    car.PrintCars();
                }
  
            }
            else
            {
                Console.WriteLine("Enter number of busses you want to enter: ");
                numberOfVeichles = Console.ReadLine();

                for (int i = 0; i < int.Parse(numberOfVeichles); i++)
                {
                    Console.WriteLine($"Bus{i+1} - Enter number of seats that bus has:  ");
                    bus.NumberOfSeats = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Bus{i + 1} - Enter what brand this bus is(Mercedes-Benz, Man, Volvo, Iveco): ");
                    vehicleBrand = Console.ReadLine();

                    bus.AddBus(bus, vehicleBrand);


                    Console.WriteLine($"\n\nEnter drive if you want for bus {vehicleBrand} to start driving write 'drive' or write 'stop' to stop driving: ");
                    userCommand = Console.ReadLine();
                    if (userCommand.ToLower() == "drive")
                    {
                        bus.Drive();
                    }
                    else if (userCommand.ToLower() == "stop")
                    {
                        bus.Stop();
                    }
                }
                bus.PrintBusses();
            }
        }
    }
}