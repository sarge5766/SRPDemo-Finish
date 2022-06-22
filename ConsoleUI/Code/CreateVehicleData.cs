using System;

namespace ConsoleUI {
    public class CreateVehicleData {
        public static Vehicle Capture() {
            Vehicle vehcile = new Vehicle();

            Console.WriteLine("What color is your vehicle: ");
            vehcile.Color = Console.ReadLine();

            Console.WriteLine("What make is your vehicle: ");
            vehcile.Make = Console.ReadLine();

            Console.WriteLine("What model is your vehicle: ");
            vehcile.Model = Console.ReadLine();

            return vehcile;
        }
    }
}
