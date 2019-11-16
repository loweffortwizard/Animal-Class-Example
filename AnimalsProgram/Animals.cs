using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Creating base class of animals for inheritence by other classess.
/// These other classes will be more specific type of animals, but with similar atributes (in this case fields and methods) with each-other. 
/// </summary>

namespace AnimalsProgram
{
    //Creating base class for Animals. 
    class Animals
    {
        //Declaring private fields for Animals class. 
        private string NameOfAnimal;
        private int DateOfBirth;
        private string TypeOfAnimal;

        //Creating constructor for Animals class. 
        public Animals(string nameOfAnimal, int dateOfBirth, string typeOfAnimal)
        {
            //Private string NameOfAnimal has value of nameOfAnimal returned from Program.cs
            this.NameOfAnimal = nameOfAnimal;

            //Private string DateOfBirth has value of dateOfBirth returned from Program.cs
            this.DateOfBirth = dateOfBirth;

            //Private string TypeOfAnimal has value of typeOfAnimal returned from Program.cs
            this.TypeOfAnimal = typeOfAnimal;
        }//end of Animals constructor.

        /// <summary>
        /// Creating getter and setter for NameOfAnimal
        /// </summary>
        /// <param name="nameOfAnimal"></param>

        //creating setter for NameOFAnimal field. 
        public void SetNameOfAnimal(string nameOfAnimal)
        {
            this.NameOfAnimal = nameOfAnimal;
        }//end of setter. 

        //creating getter for NameOfAnimal field. 
        public string GetNameOfAnimal()
        {
            return NameOfAnimal;
        }//end of getter. 

        /// <summary>
        /// Creating setter and getter for DateOfBirth
        /// </summary>
        /// <param name="dateOfBirth"></param>

        //creating setter for NameOFAnimal field. 
        public void SetDateOfBirth(int dateOfBirth)
        {
            this.DateOfBirth = dateOfBirth;
        }//end of setter. 

        //creating getter for NameOfAnimal field. 
        public int GetDateOfBirth()
        {
            return DateOfBirth;
        }//end of getter. 

        /// <summary>
        /// Creating getter and setter for TypeOfAnimal fields. 
        /// </summary>
        /// <param name="typeOfAnimal"></param>

        public void SetTypeOfAnimal(string typeOfAnimal)
        {
            this.TypeOfAnimal = typeOfAnimal; 
        }//end of setter

        public string GetTypeOfAnimal()
        {
            return TypeOfAnimal; 
        }//end of getter

        public void Noise()
        {
            Console.WriteLine("Me animal. ");
        }//end of method. 

    }//end of Animals class.
}//end of AnimalsProram namespace. 
