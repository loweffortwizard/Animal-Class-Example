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
    //creating inheritend class Aquatic, a divrivative of class Animals. 
    class Aquatic : Animals
    {
        //declaring a private string in Aquatic class with unique ID of OceanLocation
        private string OceanLocation;

        //Creating construtor method for Aquatic class. 
        //Constructors have the same name as the class, and is used to initialize the variables used for a new instance of a class,
        //known as an object.
        public Aquatic(string nameOfAnimal, int dateOfBirth, string location) : base(nameOfAnimal, dateOfBirth, "Aquatic"){
            //Private string OceanLocation has value of location returned from Program.cs
            this.OceanLocation = location;
        }//end of constructor

        //creating setter for location field. 
        public void SetLocationOfAquatic(string location){
            this.OceanLocation = location;
        }//end of setter. 

        //creating getter for WorldLocation field. 
        public string GetLocationOfAquatic(){
            return OceanLocation;
        }//end of getter. 
    }
}
