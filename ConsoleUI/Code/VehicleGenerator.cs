using System;

namespace ConsoleUI {
    public class VehicleGenerator {
        public static void CreateVehicle(Vehicle vehicle) {
            Console.WriteLine($"Your vehicle is { vehicle.Make } { vehicle.Model } its color is { vehicle.Color }");
        }
    }
}
