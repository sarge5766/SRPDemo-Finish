namespace ConsoleUI {
    class Program {
        static void Main(string[] args) {
            CreateVehicle();
        }

        static void CreateVehicle() {
            Welcome.Message();
            var vehcile = CreateVehicleData.Capture();
            bool isVehicleValid = VehcileValidator.Validate(vehcile);

            if (!isVehicleValid) {
                EndApplication.Message();
                return;
            }

            VehicleGenerator.CreateVehicle(vehcile);
            EndApplication.Message();
        }
    }
}
