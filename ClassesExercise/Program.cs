using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
            
        {
            var Lot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            var glebsCar = new Car();
            glebsCar.Make = "Ford";
            glebsCar.Model = "Focus";
            glebsCar.Year = 2013;
            glebsCar.EngineNoise = "vroom";
            glebsCar.HonkNoise = "beep";
            glebsCar.IsDrivable = true;
            Lot.Cars.Add(glebsCar);

            var isabelsCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber truck",
                EngineNoise = "...",
                HonkNoise = "brrrmp",
                IsDrivable = false
            };

            Lot.Cars.Add(isabelsCar);


            var nicolaisCar = new Car(2013, "Honda", "Civic", "vrooom", "vruuuuga", true);

            Lot.Cars.Add(nicolaisCar);

            glebsCar.MakeEngineNoise(glebsCar.EngineNoise);
            isabelsCar.MakeEngineNoise(isabelsCar.EngineNoise);
            nicolaisCar.MakeEngineNoise(nicolaisCar.EngineNoise);


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in Lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }

    }

}
