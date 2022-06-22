namespace ConsoleUI {
    public class VehcileValidator {
        public static bool Validate(Vehicle vehicle) {
            if (string.IsNullOrWhiteSpace(vehicle.Color)) {
                DisplayError.Message("color");
                
                return false;
            }

            if (string.IsNullOrWhiteSpace(vehicle.Make)) {
                DisplayError.Message("make");

                return false;
            }

            if (string.IsNullOrWhiteSpace(vehicle.Model)) {
                DisplayError.Message("model");

                return false;
            }

            return true;
        }
    }
}
