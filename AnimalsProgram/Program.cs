using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importing libs

/// <summary>
/// This animals program will show class/object creation as well as class inheritance. 
/// This will be done though many dirivative class, dirived from one base class.
/// This will create parent child relations. 
/// </summary>

namespace AnimalsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object based on animals class.
            Animals basicAnimal = new Animals("Tom", 2009, "Dog");

            //string local variable animalName is assigned value of returned value from GetNameOfAnimal()
            string animalName = basicAnimal.GetNameOfAnimal();
            //int local variable animalDOB is assigned value of returned value from GetDateOfBirth()
            int animalDOB = basicAnimal.GetDateOfBirth();
            //string local variable animalType is assigned value of returned value from GetTypeOfAnima()
            string animalType = basicAnimal.GetTypeOfAnimal();

            //print results. 
            Console.WriteLine("Name: " + animalName + "\nDOB: " + animalDOB + "\nType: " + animalType + "\n");

            //setting new value for object basicAnimal DOB to 2010.
            basicAnimal.SetDateOfBirth(2010);

            //local var animalDOB has value of returned value from GetDateOfBirth()
            animalDOB = basicAnimal.GetDateOfBirth();

            //print results. 
            Console.WriteLine("Name: " + animalName + "\nDOB: " + animalDOB + "\nType: " + animalType + "\n");
            
            //Run Mammal method.
            Mammal();
            //run Aquatic method
            Aquatic();
            //run Crab method
            Crab();

            //wait for keypress to end.
            Console.ReadKey();
        }//end of main method

        //Method for creating mammal object - Child of Animals class. 
        static void Mammal()
        {
            Mammals basicMammal = new Mammals("Sam", 2008, "Africa");

            string mammalName = basicMammal.GetNameOfAnimal();
            int mammalDOB = basicMammal.GetDateOfBirth();
            string mammalLocation = basicMammal.GetLocationOfMammal();

            //print results. 
            Console.WriteLine("Name: " + mammalName + "\nDOB: " + mammalDOB + "\nLocation: " 
                + mammalLocation + "\nType: " + basicMammal.GetTypeOfAnimal() + "\n");
        }//end of mamamal method.

        //Method for creating aquatic object - Child of Animals class. 
        static void Aquatic()
        {
            Aquatic basicAquatic = new Aquatic("Tim", 2006, "Atlantic");

            string aquaticName = basicAquatic.GetNameOfAnimal();
            int aquaticDOB = basicAquatic.GetDateOfBirth();
            string aquaticLocation = basicAquatic.GetLocationOfAquatic();

            //print results
            Console.WriteLine("Name: " + aquaticName + "\nDOB: " + aquaticDOB + "\nLocation: " 
                + aquaticLocation + "\nType: " + basicAquatic.GetTypeOfAnimal() + "\n");
        }//end of Aquatic method.

        //Method for creating crab object - Child of Aquatic class, which is a child of Animals. Making crabs class a grand-child of Animals.
        static void Crab()
        {
            Crabs basicCrab = new Crabs("John", 2000, "Atlantic", "Dead Fish");

            string crabName = basicCrab.GetNameOfAnimal();
            int crabDOB = basicCrab.GetDateOfBirth();
            string crabLocation = basicCrab.GetLocationOfAquatic();
            string crabFood = basicCrab.GetFood();

            //print resuls.
            Console.WriteLine("Name: " + crabName + "\nDOB: " + crabDOB + "\nLocation: " 
                + crabLocation + "\nFood" + crabFood);
        }//end of crab

    }//end of program class. 
}//end of namespace
