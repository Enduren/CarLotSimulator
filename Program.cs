using System;
using System.Collections.Generic;

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
            //The methods should take one string parameter: the respective noise property                                     //Done


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var Car1 = new Car() { Year = "2016", Make = "Honda", Model = "Acord", EngineNoise = "Vrrrrm", HonkNoise = "Beep", IsDriveable = true };

            var Car2 = new Car("2021", "Nissian", "Altima", "vreeeem", "Beep, beep", false);

            var Car3 = new Car();
            Car3.Year = "1990";
            Car3.Make = "Ford";
            Car3.Model = "Mustang";
            Car3.EngineNoise = "na";
            Car3.HonkNoise = "Beeeeeepppppppppppp";
            Car3.IsDriveable = false;


            Car1.MakeEngineNoise();
            Car1.MakeHonkNoise();
            Car2.MakeEngineNoise();
            Car2.MakeHonkNoise();
            Car3.MakeEngineNoise();
            Car3.MakeHonkNoise();


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car                   //Done

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var carLot1 = new CarLot(new List<Car>());   
            carLot1.MyCarList.Add(Car1);
            carLot1.MyCarList.Add(Car2);
            carLot1.MyCarList.Add(Car3);

            Console.WriteLine("Our Car Lot has these vehicles:");

            foreach (var num in carLot1.MyCarList)
            {
                Console.WriteLine(num.Year);
                Console.WriteLine(num.Make);
                Console.WriteLine(num.Model);
            }



        }
    }
}