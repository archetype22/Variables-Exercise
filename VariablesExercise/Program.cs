using System.Runtime.CompilerServices;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, C32 Homies!");
            //declare and initialize variables
            string FavCar = "Ram TRX";
            int CarYear = 2022;
            char exclamation = '!';
            bool import = false;
            double amountOfGasUsed = 35.5;
            decimal milesDriven = 300m;

            //string interpolation
            Console.WriteLine($"My favorite truck, {FavCar}, is an import: {import}.\n" +
                $" The best year model is {CarYear}. It uses {amountOfGasUsed} gallons of gas in {milesDriven} miles, though {exclamation}");

        }
    }
}
