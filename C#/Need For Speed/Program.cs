using System;
using System.Collections.Generic;
using System.Linq;

namespace Need_For_Speed
{    
    class Program
    {
        public static void Main(string[] args)
        {
            var cars = readCarsFromConsole();
            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] operationArguments = command.Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
                string[] operationArgumentsWithoutCommand = operationArguments.Where(w => w != operationArguments[0]).ToArray();
                if (operationArguments[0] == "Drive")
                {
                    executeDriveCommandWithArgumentsOverGivenDictionary(cars, operationArgumentsWithoutCommand);
                }
                else if (operationArguments[0] == "Refuel")
                {
                    executeRefuelCommandWithArgumentsOverGivenDictionary(cars, operationArgumentsWithoutCommand);
                }
                else
                {
                    executeRevertCommandWithArgumentsOverGivenDictionary(cars, operationArgumentsWithoutCommand);
                }
                command = Console.ReadLine();
            }
            printAllCarsInfo(cars);
        }
        
        public static Dictionary<string, Dictionary<string, long>> readCarsFromConsole()
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split('|');
                string car = data[0];
                long mileage = long.Parse(data[1]);
                long fuel = long.Parse(data[2]);
                var carData = new Dictionary<string, long>();
                carData.Add("mileage", mileage);
                carData.Add("fuel", fuel);
                dict.Add(car, carData);
            }
            return dict;
        }

        public static void printAllCarsInfo(Dictionary<string, Dictionary<string, long>> dict)
        {
            var dictOrdered = dict.OrderByDescending(x => x.Value["mileage"]).ThenBy(x => x.Key);
            foreach (var car in dictOrdered)
            {
                string m = "mileage";
                string f = "fuel";
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[m]} kms, Fuel in the tank: {car.Value[f]} lt.");
            }
        }

        public static void executeDriveCommandWithArgumentsOverGivenDictionary(Dictionary<string, Dictionary<string, long>> dict, string[] args)
        {
            string carName = args[0];
            long carMileage = long.Parse(args[1]);
            long carFuel = long.Parse(args[2]);
            var carDict = dict[carName];

            if (carFuel > carDict["fuel"])
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            else
            {
                carDict["mileage"] += carMileage;
                carDict["fuel"] -= carFuel;
                Console.WriteLine($"{carName} driven for {carMileage} kilometers. {carFuel} liters of fuel consumed.");
            }
            if (carDict["mileage"] > 100000)
            {
                Console.WriteLine("Time to sell the {0}!", carName);
                dict.Remove(carName);
            }
        }

        public static void executeRefuelCommandWithArgumentsOverGivenDictionary(Dictionary<string, Dictionary<string, long>> dict, string[] args)
        {
            string carName = args[0];
            long carFuel = long.Parse(args[1]);

            var carDict = dict[carName];

            carDict["fuel"] += carFuel;

            long fueledLiters = carFuel;

            if (carDict["fuel"] > 75)
            {
                fueledLiters = carFuel - (carDict["fuel"] - 75);
                carDict["fuel"] = 75;
            }
            Console.WriteLine($"{carName} refueled with {fueledLiters} liters");
        }

        public static void executeRevertCommandWithArgumentsOverGivenDictionary(Dictionary<string, Dictionary<string, long>> dict, string[] args)
        {
            string carName = args[0];
            long kill = long.Parse(args[1]);

            var carDict = dict[carName];
            carDict["mileage"] -= kill;
            if (carDict["mileage"] >= 10000)
            {
                Console.WriteLine($"{carName} mileage decreased by {kill} kilometers");
            }
            else
            {
                carDict["mileage"] = 10000;
            }
        }
    }
}
