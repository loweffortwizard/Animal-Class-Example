using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This is a child class of Animals.
/// It uses the fields and method in Animals. 
/// This child has a field for location of the aquatic animal and methods for getting and setting location. 
/// </summary>

namespace AnimalsProgram
{
    class Mammals : Animals
    {
        //Defining private string with unique ID knonw as WorldLocation
        private string WorldLocation;

        //Creating construtor method for Mammals class. 
        //Constructors have the same name as the class, and is used to initialize the variables used for a new instance of a class,
        //known as an object.
        public Mammals(string nameOfAnimal, int dateOfBirth, string location) : base(nameOfAnimal, dateOfBirth, "Mammal")
        {
            this.WorldLocation = location;
        }//end of constructor

        //creating setter for location field. 
        public void SetLocationOfMammal(string location)
        {
            this.WorldLocation = location;
        }//end of setter. 

        //creating getter for WorldLocation field. 
        public string GetLocationOfMammal()
        {
            return WorldLocation;
        }//end of getter. 

        //poly
        public void Noise()
        {
            Console.WriteLine("Me mammal. ");
        }//end of method. 
    }
}
