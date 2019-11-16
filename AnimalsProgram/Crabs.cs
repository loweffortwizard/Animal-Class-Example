using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsProgram
{
    class Crabs : Aquatic
    {
        public string Food;

        public Crabs(string nameOfCrab, int dateOfBirth, string location, string crabFood) : base(nameOfCrab, dateOfBirth, "Atlantic")
        {
            this.Food = crabFood;
        }//end of crabs

        //creating setter for location field. 
        public void SetFood(string crabFood)
        {
            this.Food = crabFood;
        }//end of setter. 

        //creating getter for WorldLocation field. 
        public string GetFood()
        {
            return Food;
        }//end of getter. 
    }
}
