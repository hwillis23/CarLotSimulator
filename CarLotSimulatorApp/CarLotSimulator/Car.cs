using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car   //car class
    {
        public Car()  //Constructor -DONE
        {
        }

        public Car(int year, string model, string make, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;  

        }

        //Properties - use PascalCasing for name (yr, model, etc)
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable -DONE
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise {get; set;}
        public string HonkNoise {get; set;}
        public bool IsDriveable { get; set; } = true; //default value (= true;) is optional 

        //Create Two methods: MakeEngineNoise(), MakeHonkNoise()-DONE
        public void MakeEngineNoise()
        {
            Console.WriteLine($"Car sounds like {EngineNoise}"); 
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"My car goes {HonkNoise} with I use my horn.");
        
        }

    }
}
