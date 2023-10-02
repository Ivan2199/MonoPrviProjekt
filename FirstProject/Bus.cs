using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Bus : Vehicle
    {
        private int numberOfSeats;
        private List<Bus> Busses = new List<Bus>();
        public Bus(string vehicleType, string vehicleBrand, int numberOfSeats)
        {
            this.VehicleBrand = vehicleBrand;
            this.NumberOfSeats = numberOfSeats;
            this.VehicleType = vehicleType;
        }
        public Bus(){}
        public int NumberOfSeats
        {
            get { return numberOfSeats; }
            set
            {
               numberOfSeats = value;
            }
        }

        public void AddVehicle(Bus bus, string vehicleBrand)
        {
            this.VehicleBrand = vehicleBrand;
            Busses.Add(new Bus(bus.VehicleType, bus.VehicleBrand, bus.NumberOfSeats));
        }

        internal void PrintVehicle()
        {
            foreach (Bus buss in Busses)
            {
                Console.WriteLine("\nBus brand: " + buss.VehicleBrand + " \nNumber of seats in bus: " + buss.NumberOfSeats);
            }
        }
        public override void Drive()
        {
            Console.WriteLine("Bus is driving");
        }
        public override void Stop()
        {
            Console.WriteLine("Bus has stopped");
        }
    }
}
