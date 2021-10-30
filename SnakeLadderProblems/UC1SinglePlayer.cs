using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblems
{
    class UC1SinglePlayer
    {
        public void snakeLadderUC1()  //here declare method
        { 
            int Is_Present = 1;
            Random random = new Random(); //use Random class here
            int empInput = random.Next(0, 2); //possibilites of Random class here
            if (Is_Present == empInput)
            {
                Console.WriteLine("Start the game your possition is: 0");
                int rollDiaValue = random.Next(1, 6);  //roll dia 

                Console.WriteLine("Roll Dia Value is:" + rollDiaValue);
            }
            else
            {
                Console.WriteLine(" play again");
            }
        }
    }
}
