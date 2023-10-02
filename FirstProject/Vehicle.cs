using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public abstract class Vehicle : IVehicleAction
    {
        protected string VehicleType { get; set; }  
        protected string VehicleBrand { get; set; }


        internal virtual void AddVehicle(Car car, string vehicleBrand)
        {
            car.VehicleBrand = vehicleBrand;
        }
        internal virtual void PrintVehicle()
        {
            Console.WriteLine("Default list of vehicles");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Vehicle is driving");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle stopped");
        }
    }
}
