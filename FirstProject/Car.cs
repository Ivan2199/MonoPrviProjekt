using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Car : Vehicle
    {
        private string carType;
        private int topSpeed;
        private List<Car> Cars = new List<Car>();

        public Car() { }

        public Car(string vehicleType,string vehicleBrand, string carType, int topSpeed)
        {
            this.VehicleBrand = vehicleBrand;
            this.VehicleType = vehicleType;
            this.CarType = carType;
            this.TopSpeed = topSpeed;
        } 

        public int TopSpeed
        {
            get { return topSpeed; } 
            set { topSpeed = value; }
        }
        public string CarType
        {
            get { return carType; }
            set {
                if(value.ToLower() == "suv" || value.ToLower() == "sedan" || value.ToLower() == "coupe" || value.ToLower() == "hatchback" || value.ToLower() == "roadster")
                {
                    carType = value;
                }
                else { Console.WriteLine("You havent written corresponding cart type so default car type will be SUV");
                    carType = "SUV";
                }
            }
        }

        internal override void AddVehicle(Car car, string vehicleBrand)
        {

                this.VehicleBrand = vehicleBrand;
                Cars.Add(new Car(car.VehicleType, car.VehicleBrand, car.CarType, car.TopSpeed));
        }
        internal override void PrintVehicle()
        {
            foreach(Car car in Cars)
            {
                Console.WriteLine("\nCar brand: " + car.VehicleBrand + "\nCar type: " +  car.CarType + "\nTop speed of the car: " + car.TopSpeed);
            }
        }
        public override void Drive()
        {
            Console.WriteLine("Car is driving");
        }
        public override void Stop()
        {
            Console.WriteLine("Car has stopped");
        }
    }
}
