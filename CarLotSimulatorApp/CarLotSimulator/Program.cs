using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car

            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            //DONE

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //Dot notation
            Car c1 = new Car();
            c1.Make = "Ford";
            c1.Model = "F-150";
            c1.Year = 2015;
            c1.EngineNoise = "VROOM VROOM";
            c1.HonkNoise = "HONK HONK";
            c1.IsDrivable = true;

            //object initalizer
            Car c2 = new Car()
            {
                Make = "Chevy",
                Model = "Avalanche",
                Year = 2004,
                EngineNoise = "brum brum",
                HonkNoise = "Beep Beep",
                IsDrivable = true,
            };

            //Custom Constructor
            Car c3 = new Car(2022, "Ford", "Mustang");


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//
            Console.WriteLine($"Number of Cars Created: {CarLot.NumberOfCars}");
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
