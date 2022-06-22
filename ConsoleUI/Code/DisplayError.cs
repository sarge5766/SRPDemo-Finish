using System;

namespace ConsoleUI {
    public class  DisplayError {
        public static void Message(string field) {
            Console.WriteLine($"You did not enter { field }");
        }
    }
}