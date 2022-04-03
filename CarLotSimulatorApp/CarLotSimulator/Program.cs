using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {


            //TODO

            ////Create a seperate class file called Car - DONE
            ////Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - DONE
            ////Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()-DONE /////
            // //The methods should take one string parameter: the respective noise property-DONE /////


            //Now that the Car class is created, we can instanciate 3 new cars
            var corevette = new Car();
            

            //using dot notation
            corevette.Year = 2022; 
            corevette.Make = "Chevrolet";
            corevette.Model = "Stingray";
            corevette.EngineNoise = "vroom!!";
            corevette.HonkNoise = "bleep!";
            corevette.IsDriveable = true;
           var carLot = new CarLot();

            //Object initalizer synax 
            var toyota = new Car()
            {
                Year = 2022,
                Make = "Toyota",
                Model = "LandCruiser",
                EngineNoise = "grumm!",
                HonkNoise = "blah",
                IsDriveable = true,

            };

            //add to the carlot
            carLot.ParkingLot.Add(corevette);
            carLot.ParkingLot.Add(toyota);


            //custom constructor - must be in the order 
            
            var landRover = new Car(2008, "LandRover", "Jaguar", "pluub...dead!!", "burrrp", false);
            carLot.ParkingLot.Add(landRover);



            //Set the properties for each of the cars
            //Call each of the methods for each car
            corevette.MakeEngineNoise(); 
            toyota.MakeEngineNoise();
            landRover.MakeEngineNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars

            //instatiate carlot 
            //carLot.ParkingLot.Add(landRover);
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end, iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine($"Added cars: {CarLot.NumberOfCars}");
            foreach(var car in carLot.ParkingLot)
            {
                Console.WriteLine($"Year: {car.Year} Make:{car.Make} and Model: {car.Model}");
                car.MakeHonkNoise();
                car.MakeEngineNoise();

            }

        
        }


    }
}
