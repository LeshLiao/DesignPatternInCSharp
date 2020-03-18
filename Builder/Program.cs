using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Builder pattern without Director(Shop.cs)

            VehicleBuilder builder;
            builder = new ScooterBuilder();
            builder.MyConstruct();
            Vehicle firstVehicle = builder.Vehicle;
            firstVehicle.Show();

            builder = new CarBuilder();
            builder.MyConstruct();
            Vehicle secondVehicle = builder.Vehicle;
            secondVehicle.Show();

            builder = new MotorCycleBuilder();
            builder.MyConstruct();
            Vehicle thirdVehicle = builder.Vehicle;
            thirdVehicle.Show();

            Console.ReadKey();
        }
    }
}
